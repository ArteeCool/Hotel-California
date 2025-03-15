using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HotelCalifornia
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _entities;

        public Repository(List<T> entities)
        {
            _entities = entities;
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
        }

        public void Delete(T entity)
        {
            if (!_entities.Contains(entity))
            {
                Console.WriteLine("Entity not found.");
                return;
            }
            _entities.Remove(entity);
        }

        public List<T> Read()
        {
            return new List<T>(_entities);
        }

        public void Update(T entity)
        {
            var index = _entities.FindIndex(e => e.Id == entity.Id);
            _entities[index] = entity;
        }
    }
}
