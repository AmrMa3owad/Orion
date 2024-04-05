﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Models.Common;

public class BaseEntity<IType> : IBaseEntity<IType>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public IType Id { get; set; }
}