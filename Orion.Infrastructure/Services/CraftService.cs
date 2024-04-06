﻿using Orion.Context;
using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class CraftService
        : BaseService<Craft, int>,
            ICraftService
    {
        public CraftService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}