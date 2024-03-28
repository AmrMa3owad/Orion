namespace Orion.Models
{
    public class Craft : BaseEntity<int>
    {
        public Craft()
        {
            Mentors = new HashSet<Mentor>();
        }
        public string CraftName { get; set; }
        public string CraftItem { get; set; }

        public virtual ICollection<Mentor> Mentors { get; set; }
    }
}
