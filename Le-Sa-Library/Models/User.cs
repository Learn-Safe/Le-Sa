namespace Le_Sa_Library.Models
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNo { get; set; }
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public string? DOB { get; set; }
        public Picture? ProfilePicture { get; set; } = new Picture();
        public AccountStatus? Status { get; set; }
        public string? Duration { get; set; }
        public string? Start { get; set; }
        public List<Device>? devices { get; set; } = new List<Device>();
        public List<string>? PastPasswords { get; set; } = new List<string>();
    }
}
