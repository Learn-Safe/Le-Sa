using System.Net;

namespace Le_Sa_Library.Models
{
    public class Device
    {
        public string? Name{ get; set; }
        public IPAddress? IP { get; set; }
        public string? MacAddress { get; set; }
        public OperatingSystem? OS { get; set; }
        public DateTimeOffset? LastLogin { get; set; }
        public Settings? DeviceSettings { get; set; }
        public List<Browser>? Browsers { get; set; }
        //public string? Status { get; set; }  
    }
}