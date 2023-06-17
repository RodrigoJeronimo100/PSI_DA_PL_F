using System;
using System.Collections.Generic;
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
                int numeroSalasExistente = comboBoxSalas.Items.Count;
                int numeroSalasNovo = quantidadeSalas + numeroSalasExistente;

                for (int i = numeroSalasExistente + 1; i <= numeroSalasNovo; i++)
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
                MessageBox.Show("Insira um valor v�lido para a quantidade de salas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Declara��o do dicion�rio para armazenar os bot�es de cada sala
        private Dictionary<string, List<Button>> salasBotoes = new Dictionary<string, List<Button>>();

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
                    // Verifica se a sala j� possui bot�es adicionados
                    if (!salasBotoes.ContainsKey(salaSelecionada))
                    {
                        salasBotoes[salaSelecionada] = new List<Button>();
                    }
                    else
                    {
                        // Se a sala j� possui bot�es adicionados, remove os bot�es existentes
                        List<Button> botoesExistentes = salasBotoes[salaSelecionada];
                        foreach (Button botaoExistente in botoesExistentes)
                        {
                            tableLayoutPanel1.Controls.Remove(botaoExistente);
                        }
                        botoesExistentes.Clear();
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
                                novoAssento.Margin = new Padding(0); // Definir margens como zero

                                // Adiciona o bot�o � lista correspondente � sala selecionada
                                salasBotoes[salaSelecionada].Add(novoAssento);

                                tableLayoutPanel1.Controls.Add(novoAssento, j, i);
                            }
                        }
                    }

                    // Adjust the column styles to make the first column wider
                    tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 50);

                    MessageBox.Show("Assentos adicionados com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("As linhas e colunas devem ser n�meros inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma sala e insira valores v�lidos para linha e coluna.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }