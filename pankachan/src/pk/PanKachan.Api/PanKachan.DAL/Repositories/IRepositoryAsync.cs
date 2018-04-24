using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PanKachan.DAL.Repositories
{
    public interface IRepositoryAsync<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Table { get; }
        Task<TEntity> GetByIdAsync(string id);

        Task<int> InsertAsync(TEntity entity);
        Task<int> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        Task<int> DeleteAsync(IEnumerable<TEntity> entities);
    }
}
