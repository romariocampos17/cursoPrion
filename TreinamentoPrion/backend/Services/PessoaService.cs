using backend.Entities;
using Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Services
{
    class PessoaService : GenericService<Pessoa>
    {
        public override List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add( new Pessoa {
            Email = "romariocampos@gmail.com"
            });
            return pessoas;
        }
    }
}
