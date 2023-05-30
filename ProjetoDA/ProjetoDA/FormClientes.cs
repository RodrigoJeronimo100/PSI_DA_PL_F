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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void button_inserir_dados_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            if(nome.Length == 0)
            {
                MessageBox.Show("O nome não pode ser vazio");
                return;
            }
            
            string nif = textBoxNif.Text;
            if (nif.Length != 9)
            {
                MessageBox.Show("O formato do Nif é invalido");
                return;
            }

            int nifNum = 0;
            try
            {
                nifNum = int.Parse(nif);

                if (nifNum < 100000000)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("O formato de Nif é invalido");
                return;
            }

            string telemovel = textBoxTelemovel.Text;
            int telemovel_int = 0;
            try
            {
                telemovel_int = int.Parse(telemovel);

                if (telemovel_int < 910000000 || telemovel_int > 939999999 && telemovel_int < 960000000 || telemovel_int > 969999999)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Numero de telemovel invalido");
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTelemovel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
