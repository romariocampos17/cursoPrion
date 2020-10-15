using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class GenericService<T> : IDisposable where T : class
    {
        

        private GenericRepository<T> Repository;

        public GenericService()
        {
            repository = new GenericRepository();
        }

        public void Add(T entity)
        {
            repository.Add(entity);
        }

        public void Update(T entity)
        {
            repository.Entry(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}