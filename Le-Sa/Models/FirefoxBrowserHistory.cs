using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Sa.Models
{
    class FirefoxBrowserHistory : BrowseHistory
    {
        public FirefoxBrowserHistory()
        {
            path = ReadFirefoxProfile() + "/places.sqlite";
            query = @"SELECT url AS URL, title AS TITLE, time(visit_date / 1000000, 'unixepoch') AS TIME, date(visit_date / 1000000, 'unixepoch') AS DATE 
                      FROM moz_historyvisits, moz_places WHERE moz_historyvisits.place_id=moz_places.id ORDER BY visit_date";
            name = "Firefox";
        }

        #region Find Firefox Data Location
        private static string ReadFirefoxProfile()
        {
            string mozillaDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla");

            if (Directory.Exists(mozillaDir))
            {
                string firefoxDir = Path.Combine(mozillaDir, "Firefox");

                if (Directory.Exists(firefoxDir))
                {
                    string prof_file = Path.Combine(firefoxDir, "profiles.ini");

                    if (File.Exists(prof_file))
                    {
                        StreamReader rdr = new StreamReader(prof_file);

                        string[] lines = rdr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        string location = lines.First(x => x.Contains("Default=")).Split(new string[] { "=" }, StringSplitOptions.None)[1];

                        return Path.Combine(firefoxDir, location);
                    }
                }
            }
            return "";
        }
        #endregion
    }
}
