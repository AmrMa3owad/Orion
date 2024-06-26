﻿using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Mentor : BaseEntity<int>
    {
        public string MentorArea { get; set; }
        public int OrphanNumber { get; set; }
        public int VisitNumber { get; set; }
        public int CraftId { get; set; }

        public virtual Craft Craft { get; set; }
    }
}
