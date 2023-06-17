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
        ApplicationContext applicationContext;
        List<Clientes> ListaClientes;
        public FormClientes()
        {
            InitializeComponent();
            applicationContext = new ApplicationContext();

            ListaClientes = new List<Clientes>();

        }
    }
}
