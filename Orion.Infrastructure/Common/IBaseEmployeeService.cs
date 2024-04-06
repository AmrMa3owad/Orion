using Orion.Domain.Models.Common;

namespace Orion.Infrastructure.Common
{
    public interface IBaseEmployeeService<T, IType> where T : IBaseEmployee<IType>
    {
        Task<T> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T?> Get(IType id, CancellationToken cancellationToken);
        IQueryable<T> GetAll(CancellationToken cancellationToken);
    }
}
