using backend.Entities;
using backend.Repositories;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Services
{
    public class UsuarioService : GenericService<Usuarios>
    {
        public Usuarios GetUsuarioPorEmail(string email)
        {
            //UsuarioRepository usuarioRepository = (UsuarioRepository)this.repository;

            Usuarios u = new Usuarios()
            {
                Id = 1,
                Nome = "Romario",
                Email = "Romario@",
                Senha = "123"
            };

            return u;
            //return usuarioRepository.GetUsuarioPorEmail(email);
        }

    }
}
