using backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Context
{
    public class GenericContext : DbContext
    {
        public GenericContext() : base("teste")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set;}
    }
}
