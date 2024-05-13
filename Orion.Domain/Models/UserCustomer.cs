using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class UserCustomer : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
