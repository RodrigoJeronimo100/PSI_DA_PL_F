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
    public partial class Principal : Form
    {
        private Funcionarios formFuncionarios;
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button_func_Click(object sender, EventArgs e)
        {

            if (formFuncionarios == null)
            {
                formFuncionarios = new Funcionarios();
                formFuncionarios.FormClosed += (s, args) => formFuncionarios = null; 
                formFuncionarios.Show();
            }
 

        }
    }
}
