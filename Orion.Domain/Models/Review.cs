using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Review : BaseEntity<int>
    {
        public string? Msg { get; set; }
        public string? Time { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Freelancer Freelancer { get; set; }
    }
}
