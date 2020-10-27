using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace API.Controllers
{
    [Http.RoutePrefix("api")]
    public class GenericController<T> : Controller  where T : class
    {
        protected GenericService<T> services;

        public GenericController()
        {
            services = new Backend.Services.GenericService<T>();
        }

        /// <summary>
        /// Serviço responsável por atualizar os dados no Application
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Http.Route("Add")]
        [Http.HttpPost]
        public virtual void Add(T entity)
        {
            services.Add(entity);
        }

        /// <summary>
        /// Serviço responsável por atualizar os dados no Application
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Http.Route("Update")]
        [Http.HttpPost]
        public virtual void Update(T entity)
        {
            services.Update(entity);
        }

        /// <summary>
        /// Serviço responsável por atualizar os dados no Application
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Http.Route("Delete")]
        [Http.HttpPost]
        public virtual void Delete(T entity)
        {
            services.Delete(entity);
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Http.Route("{id:int}/FindById")]
        [Http.HttpGet]
        public virtual T FindById(int id)
        {
            return services.FindById(id);
        }

        /// <summary>
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [Http.Route("FindAll")]
        [Http.HttpGet]
        public virtual List<T> FindAll()
        {
            return services.FindAll();
        }
    }
}