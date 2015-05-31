using System.Collections.Specialized;

namespace DonglesAreGreat.Core.Models
{
    public class Dongle
    {
        public bool IsBroken { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public NameValueCollection DeviceInfo { get; set; }
    }
}