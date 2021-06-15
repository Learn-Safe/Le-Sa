using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Sa.Models
{
    class ChromeBrowserHistory : BrowseHistory
    {
        public ChromeBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
            query = @"SELECT url AS URL, title AS TITLE, time(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch', 'localtime') AS TIME, date(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch') AS DATE 
                      FROM urls ORDER BY last_visit_time";
            name = "Chrome";
        }
    }
}
