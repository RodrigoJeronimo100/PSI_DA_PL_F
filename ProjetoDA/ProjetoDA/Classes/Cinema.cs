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
        public string Nome { get; set; }
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        
        public Sala(string nome)
        {
            Nome = nome;
            Linhas = 0;
            Colunas = 0;
        }

        public Sala(string nome, int linhas, int colunas)
        {
            Nome = nome;
            Linhas = linhas;
            Colunas = colunas;
        }

        public void AdicionarLinhasColunas(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
        }
    }
}
