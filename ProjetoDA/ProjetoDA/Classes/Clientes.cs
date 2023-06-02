using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    internal class Clientes
    {
        public int Nome { get; set; }
        public int Morada { get; set; }
        public int Nif { get; set; }
        public int Telemovel { get; set; }
        public Clientes()
        {

        }
        public Clientes(int telemovel)
        {
            Telemovel = telemovel;
        }
        public override string ToString()
        {
            return Telemovel.ToString() + ": ";
        }
    }
}
