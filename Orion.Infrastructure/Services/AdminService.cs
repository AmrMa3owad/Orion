﻿using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public class AdminService
        : BaseService<Admin, int>,
            IAdminService
    {
        public AdminService(
            AppDbContext context)
            : base(context)
        {

        }
    }
}