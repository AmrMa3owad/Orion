using Orion.Context;
using Orion.Infrastructure.Common;
using Orion.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Orion.Infrastructure.Services
{
    public class SupervisorService
        : BaseServiceEmployee<Supervisor, int>,
            ISupervisorService
    {
        private readonly AppDbContext _context;

        public SupervisorService(
            AppDbContext context)
            : base(context)
        {
            _context = context;
        }
        public async Task<Supervisor> GetSupervisorAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Supervisors
                .Include(f => f.Employee)
                .ThenInclude(e => e.User)
                .Include(f => f.Products)

                .FirstOrDefaultAsync(f => f.EmployeeId == id, cancellationToken);
        }
        public async Task<List<Supervisor>> GetAllInclude(CancellationToken cancellationToken)
        {
            return await _context.Supervisors
                .Include(f => f.Employee)
                .ThenInclude(e => e.User)
                .Include(f => f.Products)
                .ToListAsync(cancellationToken);
        }
    }
}