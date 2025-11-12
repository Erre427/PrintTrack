using Org.BouncyCastle.Crypto.Parameters;
using PrintTrack.Entidades;
using PrintTrack.Entidades.Enums;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PrintTrack.Forms.F_Clientes
{
    public partial class ClientesFrm : Form
    {
        private ClientesRepositorio repo = new ClientesRepositorio();
        private List<Clientes> listaClientes = new List<Clientes>();
        private Usuarios usuarioActual;
        public ClientesFrm()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            usuarioActual = VerificarUsuario.GetUsuarioActual();

            if(usuarioActual.Roles.idRoles != 0 && usuarioActual.Roles.idRoles != 1)
            {
                btnArchivo.Visible = false;
                btnNuevoCliente.Size = new System.Drawing.Size(375, 41);
            }

            dgvClientes.AutoGenerateColumns = false;
            listaClientes = repo.ObtenerClientes();

            listaClientes = listaClientes.OrderByDescending(c => c.idCliente).ToList();
            dgvClientes.DataSource = listaClientes; 

        }
        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscar.Text.ToLower();

            if (String.IsNullOrEmpty(textoBuscar))
            {
                CargarDatos();
            }
            else
            {
                var resultado = listaClientes.Where(c => c.Nombre.ToLower().Contains(textoBuscar)
                || c.Telefono.ToLower().Contains(textoBuscar)||c.Email.ToLower().Contains(textoBuscar)
                ).ToList();

                dgvClientes.DataSource= resultado;
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            DetallesClientes_Frm frm = new DetallesClientes_Frm(null, ModoFormulario.Crear);
            frm.ShowDialog();
            CargarDatos();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            Clientes clienteSeleccionado = (Clientes)dgvClientes.Rows[e.RowIndex].DataBoundItem;

            switch (dgvClientes.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":
                    DetallesClientes_Frm detalle = new DetallesClientes_Frm(clienteSeleccionado,ModoFormulario.Editar);
                    detalle.ShowDialog();
                    CargarDatos();
                    break;

                case "Archivar":
                    DialogResult resultado = MessageBox.Show($"Esta seguro de archivar el cliente: {clienteSeleccionado.Nombre}?","Archivar Cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if(resultado == DialogResult.Yes)
                    {
                        repo.ArchivarCliente(clienteSeleccionado.idCliente);
                        MessageBox.Show($"Cliente {clienteSeleccionado.Nombre} archivado con exito", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    break;
            }
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            ArchivoClientes_Frm frm = new ArchivoClientes_Frm();
            frm.ShowDialog();
            CargarDatos();
        }
    }
}
