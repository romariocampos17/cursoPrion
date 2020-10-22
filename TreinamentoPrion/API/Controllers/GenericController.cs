using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class GenericController<T> : Controller  where T : class
    {
        protected GenericService<T> services;

        public GenericController()
        {
            services = new Backend.Services.GenericService<T>();
        }

        public virtual void Add(T entity)
        {
            services.Add(entity);
        }

        public virtual void Update(T entity)
        {
            services.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            services.Delete(entity);
        }

        public virtual T FindById(int id)
        {
            return services.FindById(id);
        }

        public virtual List<T> FindAll()
        {
            return services.FindAll();
        }
    }
}