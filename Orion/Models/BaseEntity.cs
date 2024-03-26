using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Models;

public class BaseEntity<IType> : IBaseEntity<IType>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public IType Id { get; set; }
}