using System;
using System.Collections.Generic;
using System.Linq;
using Timesheets.DAL.Interfaces;
using Timesheets.Models;

namespace Timesheets.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDataContainer<T> _container;

        public Repository(IDataContainer<T> container)
        {
            _container = container;
            _container.Entities ??= new List<T>();
        }
        public T Add(T entity)
        {
            entity.CreatedAt = DateTimeOffset.Now;
            entity.Id = _container.Entities.Count() > 0 ? _container.Entities[^1].Id + 1 : 1;
            _container.Entities.Add(entity);
            return _container.Entities[^1];
        }

        public List<T> GetAll()
        {
            return _container.Entities;
        }

        public T GetById(int id)
        {
            return _container.Entities.Find(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _container.Entities.Remove(_container.Entities.Find(x => x.Id == id));
        }

        public T Update(T entity)
        {
            var entityToUpdate = _container.Entities.FirstOrDefault(x => x.Id == entity.Id);
            if (entityToUpdate == null) throw new ArgumentNullException("Entity not found");

            _container.Entities.Remove(entityToUpdate);
            entity.CreatedAt = entityToUpdate.CreatedAt;
            entityToUpdate = entity;
            _container.Entities.Add(entityToUpdate);

            return entityToUpdate;
        }
    }
}
