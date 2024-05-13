using Orion.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Models
{
    public class UserMentor : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int MentorId { get; set; }

        public virtual Mentor Mentor { get; set; }
        public virtual User User { get; set; }
    }
}
