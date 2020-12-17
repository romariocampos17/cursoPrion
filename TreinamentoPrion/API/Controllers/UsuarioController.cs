using backend.Entities;
using backend.Repositories;
using backend.Services;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : GenericController<Usuarios>
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public object Login(Usuarios user)
        {
            Usuarios u = new UsuarioService().GetUsuarioPorEmail(user.Email);
            if (u == null)
                return Request.CreateResponse(HttpStatusCode.NotFound,
                     "The user was not found.");
            bool credentials = u.Senha.Equals(user.Senha);
            if (!credentials) return Request.CreateResponse(HttpStatusCode.Forbidden,
                "The username/password combination was wrong.");
            return Request.CreateResponse(HttpStatusCode.OK,
                 TokenManager.GenerateToken(user.Nome));
        }
    }
}