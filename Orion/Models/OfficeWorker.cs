﻿using Orion.Models.Common;

namespace Orion.Models
{
    public class OfficeWorker : BaseEmployee<int>
    {
        public OfficeWorker()
        {
            Websites = new HashSet<Website>();
            Feedbacks = new HashSet<Feedback>();
        }
        public string OfficeWorkerDepartment { get; set; }
        public int DeviceId { get; set; }
        
        public virtual Device Device { get; set; }
        public virtual ICollection<Website> Websites { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}