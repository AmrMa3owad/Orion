namespace Orion.Models
{
    public class Under12 : BaseEntity<int>
    {
        public virtual Supervisor Supervisor { get; set; }
    }
}
