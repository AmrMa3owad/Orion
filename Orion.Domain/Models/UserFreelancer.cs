using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class UserFreelancer: BaseEntity<int>
    {
        public int UserId { get; set; }
        public int FreelancerId { get; set; }

        public virtual Freelancer Freelancer { get; set; }
        public virtual User User { get; set; }
    }
}
