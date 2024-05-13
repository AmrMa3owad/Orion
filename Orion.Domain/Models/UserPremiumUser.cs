using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class UserPremiumUser : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int PremiumUserId { get; set; }

        public virtual PremiumUser PremiumUser { get; set; }
        public virtual User User { get; set; }
    }
}
