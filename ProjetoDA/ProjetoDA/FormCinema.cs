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
        private FormSala1 formSala1;
        public FormCinema()
        {
            InitializeComponent();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void sala1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formSala1 == null)
            {
                formSala1 = new FormSala1();
                formSala1.FormClosed += (s, args) => formSala1 = null;
                formSala1.Show();
            }

        }
    }
}
