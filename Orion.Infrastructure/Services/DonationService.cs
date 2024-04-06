﻿using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class DonationService
        : BaseService<Donation, int>,
            IDonationService
    {
        public DonationService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}