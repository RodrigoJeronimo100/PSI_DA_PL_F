using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
        public void AdicionarLinhasColunas(int linhas, int colunas)
        {

            if (linhas <= 0 || colunas <= 0)
            {
                MessageBox.Show("Informe valores válidos para linhas e colunas.");
                return;
            }

            // Adicionar as linhas
            Linhas += linhas;

            // Adicionar as colunas
            Colunas += colunas;
        }
    }
}
