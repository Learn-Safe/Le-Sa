using System.Reflection.Metadata;

namespace Le_Sa_Library.Models
{
    public class Settings
    {
        public bool PushNotifiaction { get; set; }
        public bool EmailNotificatoion { get; set; }
        public List<BrowserSettings> BrowserSettings { get; set; } = new List<BrowserSettings>();
    }
}