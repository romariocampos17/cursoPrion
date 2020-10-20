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

        public virtual void Add(T entity)
        {
            repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            repository.Entry(entity);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual T FindById(int id)
        {
            return repository.FindById();
        }

        public virtual List<T> FindAll()
        {
            return repository.FindAll();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}