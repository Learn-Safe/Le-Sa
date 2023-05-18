namespace Le_Sa_Library.Models
{
    public class HistoryEntry
    {
        public Uri? Url { get; set; }
        public  string? Title { get; set; }
        public int VisitCount { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}