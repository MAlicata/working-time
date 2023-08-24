using System;
using System.Collections.Generic;
using System.Linq;
namespace working_time.Data
{
    public class GenericRepository<T> where T : class
    {
        private readonly List<T> _data = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return _data.FirstOrDefault(item => item.Id == id); // Suponiendo que tengas una propiedad 'Id' en tus modelos.
        }

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public void Update(T entity)
        {
            // Implementa la actualización aquí si es necesario.
        }

        public void Delete(int id)
        {
            var entityToRemove = GetById(id);
            if (entityToRemove != null)
            {
                _data.Remove(entityToRemove);
            }
        }
    }
}
