using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Domain.Models;
using Orion.Infrastructure.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Orion.Infrastructure.Services
{
    public class FreelancerService : BaseServiceUser<Freelancer, int>, IFreelancerService
    {
        private readonly AppDbContext _context;

        public FreelancerService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Freelancer> GetFreelancerWithOrphanageAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Freelancers
                .Include(f => f.Orphanage)
                .Include(f => f.Products) 
                .FirstOrDefaultAsync(f => f.UserId == id, cancellationToken);
        }
        public async Task<List<Freelancer>> GetAllInclude(CancellationToken cancellationToken)
        {
            return await _context.Freelancers
                .Include(f => f.Orphanage)
                .Include(f => f.Products)
                .ToListAsync(cancellationToken);
        }
    }
}