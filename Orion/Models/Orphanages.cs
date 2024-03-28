namespace Orion.Models
{
    public class Orphanages : BaseEntity<int>
    {
        public string OrphanagesName { get; set; }
        public int OrphanagesNumber { get; set; }
        public string OrphanageAddress { get; set; }
    }
}
