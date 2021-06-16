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
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\FData\FHis\places.sqlite";
            query = @"SELECT url AS URL, title AS TITLE, visit_count AS 'VISIT COUNT', time(visit_date / 1000000, 'unixepoch') AS TIME, date(visit_date / 1000000, 'unixepoch') AS DATE 
                      FROM moz_historyvisits, moz_places WHERE moz_historyvisits.place_id=moz_places.id ORDER BY visit_date DESC";
            name = "Firefox";
        }
    }
}
