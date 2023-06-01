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
        public Dbset<Salas> sala { get; set; }

        public Dbsey<Salas>
    }
}
