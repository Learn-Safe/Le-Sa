using Le_Sa.Structs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Le_Sa.Models.Netsh
{
    class NetshHelper
    {
        #region Netsh Command Creator
        private static Process CreateNetshProcess(string args, bool redirectOutput)
        {
            return new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = args,
                    Verb = "runas",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = redirectOutput,
                }
            };
        }
        #endregion

        #region List Network Interfaces
        public static List<Interface> GetInterfaces()
        {
            var interfaces = new List<Interface>();
            var process = CreateNetshProcess("int show interface", true);

            process.Start();

            var isList = false;

            while (!process.StandardOutput.EndOfStream)
            {
                var str = process.StandardOutput.ReadLine();

                if (string.IsNullOrEmpty(str))
                    continue;

                if (!isList)
                {
                    if (str.Length > 0 && str.StartsWith(new string(str[0], 6), StringComparison.Ordinal))
                        isList = true;

                    continue;
                }

                var match = Regex.Match(str, @"^(?<AdminState>\S+)\s+(?<State>\S+)\s+(?<Type>\S+)\s+(?<Name>.+)$");
                if (!match.Success)
                    continue;

                var @interface = new Interface
                {
                    Name = match.Groups["Name"].Value,
                };

                interfaces.Add(@interface);
            }

            return interfaces;
        }
        #endregion

        #region Flush DNS
        internal static void FlushDns()
        {
            var proc = new Process
            {
                StartInfo =
                {
                    FileName = "ipconfig",
                    Arguments = "/flushdns",
                    Verb = "runas",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            proc.Start();
            proc.WaitForExit();
        }
        #endregion

        #region Update DNS

        public static void UpdateDnsEntries(Interface @interface, string preferrdDNS, string AlternateDNS)
        {
            var proc = CreateNetshProcess($"int ip set dns name=\"{@interface.Name}\" static {preferrdDNS}", false);
            proc.Start();
            proc.WaitForExit();
            proc = CreateNetshProcess($"int ip add dns name=\"{@interface.Name}\" {AlternateDNS} index=2", false);
            proc.Start();
            proc.WaitForExit();
            FlushDns();
        }
        #endregion

        #region Reset DNS 
        public static void ResetDnsEntries(Interface @interface)
        {
            var proc = CreateNetshProcess($"int ip set dns \"{@interface.Name}\" dhcp", false);
            proc.Start();
            proc.WaitForExit();
            FlushDns();
        }
        #endregion
    }
}
