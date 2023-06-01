using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class FormCinema : Form
    {
        private int contadorSalas = 1;
        public FormCinema()
        {
            InitializeComponent();
        }
        private void Cinema_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage novaSala = new TabPage("Sala " + contadorSalas);
            tabControl1.TabPages.Add(novaSala);
            contadorSalas++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                TabPage guiaSelecionada = tabControl1.SelectedTab;
                tabControl1.TabPages.Remove(guiaSelecionada);
            }
        }
    }
}
