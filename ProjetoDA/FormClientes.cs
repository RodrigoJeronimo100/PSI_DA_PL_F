﻿using System;
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
        ApplicationContext applicationContext;
        List<Pessoa> ListaClientes;
        public FormClientes()
        {
            InitializeComponent();
            applicationContext = new ApplicationContext();

            ListaClientes = new List<Pessoa>();
            atualizarListaClientes();
        }

        private void button_inserir_dados_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            if (nome.Length == 0)
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
            foreach (Pessoa clientes in ListaClientes)
            {
                if (clientes.Telemovel == telemovel_int)
                {
                    ListaClientes.Add(clientes);
                    
                    return;
                }
            }
            Pessoa novo_cliente = new Pessoa(telemovel_int);
            ListaClientes.Add(novo_cliente);
            

            try
            {
                applicationContext.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao guardar um novo jogador!");
                return;
            }
            atualizarListaClientes();
        }

        private void atualizarListaClientes()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = ListaClientes;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTelemovel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
