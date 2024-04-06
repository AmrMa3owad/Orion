using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Models.Common
{
    public class BaseFreelancer<IType> : IBaseFreelancer<IType>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public IType Id { get; set; }
        public int Earnings { get; set; }
        public int OrphansNumber { get; set; }
        public string ProductType { get; set; }
        public bool Deleted { get; set; }
    }
}
