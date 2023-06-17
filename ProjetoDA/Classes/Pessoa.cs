using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    internal class Pessoa
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        
        public int Morada { get; set; }
        public int Nif { get; set; }
        public int Telemovel { get; set; }
        public Pessoa()
        {

        }
        public Pessoa(int telemovel)
        {
            Telemovel = telemovel;
        }
        public override string ToString()
        {
            return Telemovel.ToString() + ": ";
        }
    }
}
