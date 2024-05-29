using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Supervisor: BaseEntity<int>
    {
        public Supervisor()
        {
            Under12s = new HashSet<Under12>();
            Products = new HashSet<Product>();
            EmployeeSupervisors = new HashSet<EmployeeSupervisor>();
            SupervisorOrphanages = new HashSet<SupervisorOrphanage>();
        }
        public byte[] SupervisorPhoto { get; set; }
        public string SupervisorSkill { get; set; }
        public string SupervisorInfo { get; set; }
        public string SupervisorRegion { get; set; }

        public virtual ICollection<Under12> Under12s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<EmployeeSupervisor> EmployeeSupervisors { get; set; }
        public virtual ICollection<SupervisorOrphanage> SupervisorOrphanages { get; set; }
    }
}
