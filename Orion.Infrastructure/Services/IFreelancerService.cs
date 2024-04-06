﻿using Orion.Domain.Models;
using Orion.Infrastructure.Common;

namespace Orion.Infrastructure.Services
{
    public interface IFreelancerService :
        IBaseUserService<Freelancer, int>
    {
    }
}
