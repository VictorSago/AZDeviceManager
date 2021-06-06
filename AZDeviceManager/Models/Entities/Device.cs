using System;

namespace AZDeviceManager.Models.Entities
{
    public class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LatestData { get; set; }
        public DateTime LastUpdate { get; set; }
        public DeviceType Type { get; set; }
        public Location DeviceLocation { get; set; }
        public DeviceStatus Status { get; set; }

        public string StatusString => Status == DeviceStatus.Online ? "Online" : "Offline";
    }
}
