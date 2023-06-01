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
    public partial class FormSessoes : Form
    {
        public FormSessoes()
        {
            
            InitializeComponent();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            comboBoxSala.Items.Add("sala 1");
            comboBoxSala.Items.Add("sala 2");
            comboBoxSala.Items.Add("sala 3");
            comboBoxSala.Items.Add("sala 4");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxHora1.Text, out int hora1) && int.TryParse(textBoxMin1.Text, out int minutos1) && int.TryParse(textBoxHora2.Text, out int hora2) && int.TryParse(textBoxMin2.Text, out int minutos2))
            {
                

                if (hora1 >= 0 && hora1 <= 23 && minutos1 >= 0 && minutos1 <= 59 && hora2 >= 0 && hora2 <= 23 && minutos2 >= 0 && minutos2 <= 59)
                {
                    
                    MessageBox.Show("Sessão criada para as: " + hora1 +":"+ minutos1 + "\nCom fim para as: " + hora2 + ":" + minutos2);
                   
                }
                else
                {
                    MessageBox.Show("Horas ou Minutos Inválidos.");
                }
            }
            else
            {
                MessageBox.Show("Resposta Inválida.");
            }
        }

        private void textBoxHora1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHora1.Text.Length >= 2)
            {
                textBoxMin1.Focus();
            }
        }

        private void textBoxMin1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin1.Text.Length >= 2)
            {
                textBoxHora2.Focus();
            }
        }

        private void textBoxHora2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHora2.Text.Length >= 2)
            {
                textBoxMin2.Focus();
            }
        }

        private void textBoxMin2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMin2.Text.Length >= 2)
            {

            }
        }
    }
}
