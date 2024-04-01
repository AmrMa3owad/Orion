﻿using Orion.Models.Common;
using Orion.Models.Enums;

namespace Orion.Models
{
    public class Donation : BaseEntity<int>
    {
        public Donation()
        {
            Sponsors = new HashSet<Sponsor>();
        }
        public DonationTypes DonationType { get; set; }
        public double DonationQuantity { get; set; }
        public DateTime DonationTime { get; set; }
        public string DonationMethod { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
