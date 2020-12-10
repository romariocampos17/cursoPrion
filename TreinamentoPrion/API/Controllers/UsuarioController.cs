using backend.Entities;
using backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class UsuarioController : GenericController<Usuarios>
    {
        [AllowAnonymous]
        [HttpPost]
        public Object GetUsuarioPorEmail(string email)
        {
            UsuarioService usuarioService = (UsuarioService)this.services;
            return usuarioService.GetUsuarioPorEmail(email);
        }
    }
}