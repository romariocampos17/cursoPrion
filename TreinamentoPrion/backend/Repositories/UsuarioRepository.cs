using backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuarios>
    {
        public Usuarios GetUsuarioPorEmail(string email) 
        {
            return this.context.Usuario.Where(u => u.Email.Equals(email)).FirstOrDefault();
        }
    }
}
