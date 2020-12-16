using backend.Entities;
using backend.Services;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class UsuarioController : GenericController<Usuarios>
    {
        [AllowAnonymous]
        [HttpPost]
        public Object GetUsuarioPorEmail([FromBody] Usuarios user)
        {
            UsuarioService usuarioService = (UsuarioService)this.services;

            Usuarios usuario = usuarioService.GetUsuarioPorEmail(user.Email);

            if (usuario == null || usuario.Senha != user.Senha)
                throw new Exception("Usuário não existe");
            else{ 
                var json = JsonConvert.SerializeObject(usuario);
                var identidade = new ClaimsIdentity();
                identidade.AddClaim(new Claim("User", json));
                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                TimeSpan.FromSeconds(300);

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("teste"));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                Issuer = "",
                Audience = "",
                SigningCredentials = credentials,
                Subject = identidade,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
                });

                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    user = usuario,
                    message = "OK"
                };
            }     
        }
    }
}