using System;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjetoDA
{
    public partial class FormCinema : Form
    {


        public FormCinema()
        {
            InitializeComponent();
        }

        private void buttonAdicionarSalas_Click(object sender, EventArgs e)
        {
            int quantidadeSalas;

            if (int.TryParse(textBoxSalas.Text, out quantidadeSalas))
            {
                comboBoxSalas.Items.Clear();

                for (int i = 1; i <= quantidadeSalas; i++)
                {
                    string nomeSala = $"Sala {i}";
                    comboBoxSalas.Items.Add(nomeSala);
                }

                comboBoxSalas.Sorted = true;

                if (comboBoxSalas.Items.Count > 0)
                {
                    comboBoxSalas.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Insira um valor válido para a quantidade de salas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionarAssentos_Click(object sender, EventArgs e)
        {
            string salaSelecionada = comboBoxSalas.SelectedItem?.ToString();
            string linha = textBoxLinha.Text;
            string coluna = textBoxColuna.Text;

            if (!string.IsNullOrEmpty(salaSelecionada) && !string.IsNullOrEmpty(linha) && !string.IsNullOrEmpty(coluna))
            {
                int linhas, colunas;

                if (int.TryParse(linha, out linhas) && int.TryParse(coluna, out colunas))
                {
                    if (tableLayoutPanel1 != null)
                    {
                        tableLayoutPanel1.Controls.Clear(); // Clear the existing controls in tableLayoutPanel1
                    }
                    else
                    {
                        tableLayoutPanel1 = new TableLayoutPanel();
                        tableLayoutPanel1.Dock = DockStyle.Fill;
                    }

                    tableLayoutPanel1.RowCount = linhas;
                    tableLayoutPanel1.ColumnCount = colunas + 1; // Add 1 extra column

                    for (int i = 0; i < linhas; i++)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / linhas));

                        for (int j = 0; j <= colunas; j++) // Include the extra column
                        {
                            if (j == 0) // First column
                            {
                                // Add a separator panel instead of a button
                                Panel separatorPanel = new Panel();
                                separatorPanel.Width = 10;
                                tableLayoutPanel1.Controls.Add(separatorPanel, j, i);
                            }
                            else
                            {
                                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / colunas));

                                Button novoAssento = new Button();
                                novoAssento.Text = $"Assento {i + 1}-{j}";
                                novoAssento.Width = 70;
                                novoAssento.Height = 70;

                                tableLayoutPanel1.Controls.Add(novoAssento, j, i);
                            }
                        }
                    }

                    // Adjust the column styles to make the first column wider
                    tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 50);

                    // Align the first row with the rest of the rows
                    

                    MessageBox.Show("Assentos adicionados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("As linhas e colunas devem ser números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma sala e insira valores válidos para linha e coluna.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}