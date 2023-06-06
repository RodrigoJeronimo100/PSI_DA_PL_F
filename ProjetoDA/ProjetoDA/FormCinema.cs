using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            CarregarProgresso();
            
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            listView1.View = View.Details;
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TabPage novaAba = new TabPage("Sala " + contadorSalas);
            tabControl1.TabPages.Add(novaAba);

            contadorSalas++;

            SalvarProgresso(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                TabPage guiaSelecionada = tabControl1.SelectedTab;
                tabControl1.TabPages.Remove(guiaSelecionada);
            }
        }

        private void SalvarProgresso()
        {
            string arquivo = "progresso.txt";
            using (StreamWriter writer = new StreamWriter(arquivo))
            {
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    writer.WriteLine(tabPage.Text);
                }
            }
        }
        private void CarregarProgresso()
        {
            string arquivo = "progresso.txt";
            if (File.Exists(arquivo))
            {
                using (StreamReader reader = new StreamReader(arquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        TabPage novaSala = new TabPage(linha);
                        tabControl1.TabPages.Add(novaSala);
                    }
                }
            }
        }

        private int numeroUltimaSala = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidadeSalas;
            if (int.TryParse(textBoxQuantidadeSalas.Text, out quantidadeSalas))
            {
                for (int i = 1; i <= quantidadeSalas; i++)
                {
                    numeroUltimaSala++; 
                    string nomeSala = "Sala " + numeroUltimaSala;
                    comboBox1.Items.Add(nomeSala);
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido de salas.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string salaSelecionada = comboBox1.SelectedItem.ToString();
                comboBox1.Items.Remove(salaSelecionada);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 

            string nomeSalaSelecionada = comboBox1.SelectedItem.ToString();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }
    }
}
