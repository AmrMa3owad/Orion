using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class EmployeeOfficeWorker : BaseEntity<int>
    {
        public int EmployeeId { get; set; }
        public int OfficeWorkerId { get; set; }

        public virtual OfficeWorker OfficeWorker { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
