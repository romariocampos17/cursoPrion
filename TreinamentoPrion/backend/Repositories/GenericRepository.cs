using backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Repositories
{
    public class GenericRepository<T>: IDisposable where T : class
    {
        public GenericContext context;

        public GenericRepository()
        {  
            context = new GenericContext();
        }

        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();

        }

        public virtual T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual List<T> FindAll()
        {
            return context.Set<T>().ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
