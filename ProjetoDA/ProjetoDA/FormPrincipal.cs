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
    public partial class FormPrincipal : Form
    {
        ApplicationContext applicationContext;

        private FormFuncionarios formFuncionarios;
        private FormLogin formLogin;
        private FormFilme formFilme;
        private FormCinema formCinema;
        private FormSessoes formSessoes;
        private FormClientes formClientes;

        List<Pessoa> ListaClientes;
        public FormPrincipal()
        {
            InitializeComponent();
            applicationContext = new ApplicationContext();

            ListaClientes = new List<Pessoa>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button_func_Click(object sender, EventArgs e)
        {

            if (formFuncionarios == null)
            {
                formFuncionarios = new FormFuncionarios();
                formFuncionarios.FormClosed += (s, args) => formFuncionarios = null; 
                formFuncionarios.Show();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (formLogin == null)
            {
                formLogin = new FormLogin();
                formLogin.FormClosed += (s, args) => formLogin = null;
                formLogin.Show();
            }
        }

        private void button_filmes_Click(object sender, EventArgs e)
        {
            if (formFilme == null)
            {
                formFilme = new FormFilme();
                formFilme.FormClosed += (s, args) => formFilme = null;
                formFilme.Show();
            }
        }

        private void button_cinema_Click(object sender, EventArgs e)
        {
            if (formCinema == null)
            {
                formCinema = new FormCinema();
                formCinema.FormClosed += (s, args) => formCinema = null;
                formCinema.Show();
            }
        }

        private void button_sessoes_Click(object sender, EventArgs e)
        {
            if (formSessoes == null)
            {
                formSessoes = new FormSessoes();
                formSessoes.FormClosed += (s, args) => formSessoes = null;
                formSessoes.Show();
            }
        }

        private void button_clientes_Click(object sender, EventArgs e)
        {
            if (formClientes == null)
            {
                formClientes = new FormClientes();
                formClientes.FormClosed += (s, args) => formClientes = null;
                formClientes.Show();
            }
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
