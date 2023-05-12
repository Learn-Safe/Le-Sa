using System;

namespace Le_Sa.Models.History
{
    class VivaldiBrowserHistory : BrowseHistory
    {
        public VivaldiBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\VData\VHis\History";
            query = @"SELECT url AS URL, title AS TITLE, visit_count AS 'VISIT COUNT', time(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch', 'localtime') AS TIME, date(last_visit_time / 1000000 + (strftime('%s', '1601-01-01')), 'unixepoch') AS DATE
                      FROM urls ORDER BY last_visit_time DESC";
            name = "Vivaldi";
        }
    }
}