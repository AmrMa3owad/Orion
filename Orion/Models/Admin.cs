namespace Orion.Models
{
    public class Admin : BaseEntity<int>
    {
        public Admin()
        {
            Feedback = new HashSet<Feedback>();
        }
        public virtual Website Website { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual Device Device { get; set; }

    }
}
