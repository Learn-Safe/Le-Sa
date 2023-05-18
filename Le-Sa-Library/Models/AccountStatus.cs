namespace Le_Sa_Library.Models
{
    public class AccountStatus
    {
        public bool IsActive { get; set; }
        public bool IsTemporary { get; set; }
        public TimeSpan Duration { get; set; }
        public string? Reason { get; set; }
    }
}