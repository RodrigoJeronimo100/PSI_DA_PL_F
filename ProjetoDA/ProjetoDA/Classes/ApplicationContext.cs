using ProjetoDA.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    internal class ApplicationContext : DbContext
    {
        
        
        
        public DbSet<Sala> Salas { get; set; }
        //public DbSet<Filmes> Filmes { get; set; }
        
    }
}
