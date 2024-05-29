using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Admin : BaseEntity<int>
    {
        public Admin()
        {
            Feedbacks = new HashSet<Feedback>();
            EmployeeAdmins = new HashSet<EmployeeAdmin>();
            ContactUses = new HashSet<ContactUs>();
            Categories = new HashSet<Category>();
        }
        public int WebsiteId { get; set; }
        public int? DeviceId { get; set; }
   
        public virtual Website Website { get; set; }
        public virtual Device Device { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<EmployeeAdmin> EmployeeAdmins { get; set; }
        public virtual ICollection<ContactUs> ContactUses { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

    }
}
