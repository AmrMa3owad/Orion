﻿using Orion.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface ICustomerAdvertisementService :
        IBaseService<CustomerAdvertisement, int>
    {
    }
}