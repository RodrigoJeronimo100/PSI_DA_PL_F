using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Classes
{
    internal class Filmes
    {
        public string Nomefilme { get; set; }

        public TimeSpan Duracao { get; set; }
        // cria variel para o disponibilidade
        public bool Ativo { get; set; }
 
    }
}
