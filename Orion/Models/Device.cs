﻿namespace Orion.Models
{
    public class Device : BaseEntity<int>
    {
        public string DeviceType { get; set; }
        public string DeviceDateOfPurchase { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int MaintenancePrice { get; set; }
        
        public virtual Admin Admin { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }

    }
}
