namespace Le_Sa_Library.Models
{
    public class Browser
    {
        public string? Name{ get; set; }
        public string? Version { get; set; } = "Undefined";
        public DateTimeOffset InstalledDate { get; set; }
        public List<HistoryEntry> BrowserHistory { get; set; } = new List<HistoryEntry>();
    }
}