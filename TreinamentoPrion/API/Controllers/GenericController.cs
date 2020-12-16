using backend.Entities;
using Backend.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [CustomAuthorize]
    [EnableCors(origins: "*", headers:"*", methods: "*")]
    [Authorize()]
    [CustomExceptionFilter]
    public class GenericController<T> : ApiController  where T : class
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
        [HttpPost]
        public virtual void Add([FromForm] T entity)
        {
            services.Add(entity);
        }

        /// <summary>
        /// Serviço responsável por atualizar os dados no Application
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost]
        public virtual void Update(T entity)
        {
            services.Update(entity);
        }

        /// <summary>
        /// Serviço responsável por atualizar os dados no Application
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpPost]
        public virtual void Delete(T entity)
        {
            services.Delete(entity);
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual T FindById(int id)
        {
            return services.FindById(id);
        }

        /// <summary>
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpGet]
        public virtual List<T> FindAll()
        {
            return services.FindAll();
        }

        public Usuarios UsuarioLogado {
            get {var principal = (RequestContext.Principal as ClaimsPrincipal);
                var json = principal.Claims.Where(x => x.Type == "User").FirstOrDefault().Value;

                Usuarios logged = JsonConvert.DeserializeObject<Usuarios>(json);

                return logged;
                }
            set { UsuarioLogado = value; }
        }
}