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
        internal object ClientesSet;

        public DbSet <Clientes> clientes { get; set; }
        
    }
}
