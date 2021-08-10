using System.Collections.Generic;
using Timesheets.Models;

namespace Timesheets.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
        T Update(T entity);
    }
}
