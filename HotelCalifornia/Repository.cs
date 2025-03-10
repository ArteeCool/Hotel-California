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

        public Repository()
        {
            _entities = new List<T>();
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                Console.WriteLine(nameof(entity) + " is null");
                return;
            }
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
            Int32 index = _entities.FindIndex(e => e.Id == entity.Id);
            if (index == -1)
            {
                Console.WriteLine("Entity not found.");
                return;
            }
            _entities[index] = entity;
        }
    }
}
