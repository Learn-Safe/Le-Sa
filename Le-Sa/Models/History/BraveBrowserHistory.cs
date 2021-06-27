using System;

namespace Le_Sa.Models
{
    class BraveBrowserHistory : BrowseHistory
    {
        public BraveBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\BData\BHis\History";
            query = @"SELECT url AS URL, title AS TITLE, visit_count AS 'VISIT COUNT', time(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch', 'localtime') AS TIME, date(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch') AS DATE
                      FROM urls ORDER BY last_visit_time DESC";
            name = "Brave";
        }
    }
}
