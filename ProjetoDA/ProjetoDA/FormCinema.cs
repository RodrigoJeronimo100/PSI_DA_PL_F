    using ProjetoDA.Classes;
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
        
        private List<Sala> salas = new List<Sala>();
        private Sala salaSelecionada;

        public FormCinema()
        {
            InitializeComponent();
            CarregarProgresso();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
<<<<<<< HEAD

=======
            
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
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
        
        private void buttonAdicionarSalas_Click(object sender, EventArgs e)
        {
            string nomeSala = textBoxSalas.Text;

            if (string.IsNullOrEmpty(nomeSala))
            {
                MessageBox.Show("Digite um nome para a sala.");
                return;
            }
            
        Sala novaSala = new Sala(nomeSala);
            salas.Add(novaSala);
            comboBox1.Items.Add(nomeSala);

            textBoxSalas.Clear();
            textBoxSalas.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
           
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
            string nomeSalaSelecionada = comboBox1.SelectedItem.ToString();
            salaSelecionada = salas.FirstOrDefault(s => s.Nome == nomeSalaSelecionada);

            if (salaSelecionada != null)
            {
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = salaSelecionada.Linhas;
                tableLayoutPanel1.ColumnCount = salaSelecionada.Colunas;
                for (int i = salaSelecionada.Linhas; i >= 1; i--)
                {
                    for (int j = salaSelecionada.Colunas; j >= 1; j--)
                    {
                        Button button = new Button();
                        button.Text = $"Assento {i}-{j}";
                        tableLayoutPanel1.Controls.Add(button);
                    }
                    
                }
            }
            }


        private void buttonAdicionarAssentos_Click(object sender, EventArgs e)
        {
            if (salaSelecionada == null)
            {
                MessageBox.Show("Selecione uma sala antes de adicionar assentos.");
                return;
            }

            int linhas = int.Parse(textBoxLinhas.Text);
            int colunas = int.Parse(textBoxColunas.Text);

            salaSelecionada.AdicionarLinhasColunas(linhas, colunas);

            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < salaSelecionada.Linhas; i++)
            {
                for (int j = 0; j < salaSelecionada.Colunas; j++)
                {
                    Button button = new Button();
                    button.Text = $"Assento {i + 1}-{j + 1}";
                    tableLayoutPanel1.Controls.Add(button);
                }
            }


            MessageBox.Show($"As linhas e colunas foram adicionadas à sala: {salaSelecionada.Nome}");
        }

        private void button_adicionarlinhas_Click(object sender, EventArgs e)
        {
            int linhas = int.Parse(textBoxlinhas.Text);
            int colunas = int.Parse(textBoxcolunas.Text);

            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= linhas; i++)
            {
                for (int j = 1; j <= colunas; j++)
                {
                    Button button = new Button();
                    button.Text = $"Sala {i}-{j}";
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }

        private void button_adicionarcolunas_Click(object sender, EventArgs e)
        {
            int colunas = int.Parse(textBoxcolunas.Text);

            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= colunas; i++)
            {
                Button button = new Button();
                button.Text = $"Sala {i}";
                flowLayoutPanel1.Controls.Add(button);
            }
        }
    }
}
