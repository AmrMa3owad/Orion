namespace Orion.Models
{
    public class Orphanage : BaseEntity<int>
    {
        public Orphanage()
        {
            Freelancer = new HashSet<Freelancer>();
        }
        public string OrphanageName { get; set; }
        public int OrphanageNumber { get; set; }
        public string OrphanageAddress { get; set; }
        public virtual ICollection<Freelancer> Freelancer { get; set; }

    }
}
