using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models.Base;

namespace Timesheets.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<T> Remove(T entity);
        Task<T> UpdateAsync(T entity);
    }
}
