using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Security.Principal;

namespace Le_Sa.Models.AdminCheck
{
    public static class AdminCheck
    {
		private static string GetCurrentProcessPath()
		{
			// ReSharper disable once PossibleNullReferenceException
			return Process.GetCurrentProcess().MainModule.FileName;
		}

		public static bool IsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

		private static string GetCommandLine(this Process process)
		{
			using (var searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
			using (var objects = searcher.Get())
				return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
		}

		public static void RestartUnderAdmin()
		{
			var proc = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = GetCurrentProcessPath(),
					Arguments = Process.GetCurrentProcess().GetCommandLine(),
					UseShellExecute = true,
					Verb = "runas",
				},
			};

			try
			{
				proc.Start();
			}
			catch
			{
				// ignored
			}

			Environment.Exit(0);
		}

	}
}
