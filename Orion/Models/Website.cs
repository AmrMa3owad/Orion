namespace Orion.Models
{
    public class Website
    {
        public Website()
        {
            Customers = new HashSet<Customer>();
        }
        public string WebsiteName { get; set; }
        public int AdminId { get; set; }
        public int OfficeWorkerId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
