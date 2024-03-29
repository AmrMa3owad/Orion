namespace Orion.Models
{
    public class OfficeWorker : BaseEntity<int>
    {
        public OfficeWorker()
        {
            Website = new HashSet<Website>();
            Feedback = new HashSet<Feedback>();
        }
        public string OfficeWorkerDepartment { get; set; }
        public virtual ICollection<Website> Website { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual Device Device { get; set; }


    }
}
