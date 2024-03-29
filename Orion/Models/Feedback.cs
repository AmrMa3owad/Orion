namespace Orion.Models
{
    public class Feedback : BaseEntity<int>
    {
        public Feedback()
        {
            
        }
        public virtual Customer Customer { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }


    }
}
