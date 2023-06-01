using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoDA
{
    public partial class FormCinema : Form
    {
 
        public FormCinema()
        {
            InitializeComponent();
        }
        private void Cinema_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
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

=======
>>>>>>> 53beb3271d317b543b26b58e35ec7a83b328997e
        }

        private int contadorSalas = 1;
        private void button_criarsala_Click(object sender, EventArgs e)
        {
            if (textBox_novasala.Text != "")
            {
                TabPage sala = new TabPage();
                sala.Text = "Sala" + contadorSalas;
                sala.Name = "Sala" + contadorSalas;
                sala.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(sala);
                textBox_novasala.Clear();

                contadorSalas++;
            }
        }
    }
}
