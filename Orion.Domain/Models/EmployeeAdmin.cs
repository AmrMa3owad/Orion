using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class EmployeeAdmin : BaseEntity<int>
    {
        public int EmployeeId { get; set; }
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
