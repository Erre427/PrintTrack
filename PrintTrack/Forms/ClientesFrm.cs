using PrintTrack.Entidades;
using PrintTrack.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTrack.Forms
{
    public partial class ClientesFrm : Form
    {
        private ClientesRepositorio repository = new ClientesRepositorio();
        private List<Clientes> listaClientes = new List<Clientes>();   

        public void CargarClientes()
        {
            clientesDgv.AutoGenerateColumns = false;
            listaClientes = repository.ObtenerClientes();
            clientesDgv.DataSource = listaClientes;
        }

        public ClientesFrm()
        {
            InitializeComponent();
        }

        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
