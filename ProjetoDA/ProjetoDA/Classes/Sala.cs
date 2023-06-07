using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoDA.Classes
{
    internal class Sala
    {
        public string Nome { get; set; }
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Sala(string nome, int linhas, int colunas)
        {
            Nome = nome;
            Linhas = linhas;
            Colunas = colunas;
        }
    }
}
