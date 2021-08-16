using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timesheets.DAL.Interfaces;
using Timesheets.Models.Base;

namespace Timesheets.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TimesheetsDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(TimesheetsDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            await _entities.AddAsync(entity);
            _ = await _context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _entities.SingleOrDefaultAsync(s => s.Id == id);
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return entity;
        }

        public async Task<T> Remove(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
