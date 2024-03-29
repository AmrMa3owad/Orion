namespace Orion.Models
{
    public class Website
    {
        public Website()
        {
            Customer = new HashSet<Customer>();
        }
        public string WebsiteName { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }

    }
}
