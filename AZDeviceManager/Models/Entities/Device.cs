using System;

namespace AZDeviceManager.Models.Entities
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string Name { get; set; }
        public string LatestData { get; set; }
        public DateTime LastUpdate { get; set; }
        public DeviceType Type { get; set; }
        public DeviceLocation Location { get; set; }
        public DeviceStatus Status { get; set; }

        public string StatusString => Status == DeviceStatus.Online ? "Online" : "Offline";
    }
}
