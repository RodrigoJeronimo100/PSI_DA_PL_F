using ProjetoDA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    internal class Cinema
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }
        public List<Sala> Salas { get; set; }

        public Cinema(string nome, string morada, string email)
        {
            Nome = nome;
            Morada = morada;
            Email = email;
            Salas = new List<Sala>();
        }
    }

    internal class Sala
    {
        private int i;
        private int j;

        public Sala(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public string Nome { get; set; }
       
       

        

        
    }
}
