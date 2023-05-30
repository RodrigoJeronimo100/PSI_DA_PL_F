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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string username = textBox_utilizador.Text;
            string password = textBox_password.Text;

            if
        }
    }
}
