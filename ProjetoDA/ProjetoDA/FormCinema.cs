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
                formSala1 = new formSala1();
                formSala1.FormClosed += (s, args) => formSala1 = null;
                formSala1.Show();
            }
=======

=======
>>>>>>> 53beb3271d317b543b26b58e35ec7a83b328997e
        }
>>>>>>> parent of 2951ab5 (1)
=======

        }
>>>>>>> parent of 2951ab5 (1)
    }
}
