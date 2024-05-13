using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class EmployeeDelivery : BaseEntity<int>
    {
        public int EmployeeId { get; set; }
        public int DeliveryId { get; set; }

        public virtual Delivery Delivery { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
