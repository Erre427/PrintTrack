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

namespace PrintTrack.Forms.F_Clientes
{
    public partial class ArchivoClientes_Frm : Form
    {
        List<Clientes> listaClientes = new List<Clientes>();
        ClientesRepositorio repo = new ClientesRepositorio();
        ModoFormulario modo;

        public ArchivoClientes_Frm()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            dgvClientesArchivados.AutoGenerateColumns = false;
            listaClientes = repo.ObtenerClientesArchivados();
            dgvClientesArchivados.DataSource = listaClientes;
        }

        private void EditarCliente_Frm_Load(object sender, EventArgs e)
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
                || c.Telefono.ToLower().Contains(textoBuscar) || c.Email.ToLower().Contains(textoBuscar)
                ).ToList();

                dgvClientesArchivados.DataSource = resultado;
            }
        }

        private void dgvClientesArchivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Clientes clienteSeleccionado = (Clientes)dgvClientesArchivados.Rows[e.RowIndex].DataBoundItem;

            switch (dgvClientesArchivados.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":
                    DetallesClientes_Frm frm = new DetallesClientes_Frm(clienteSeleccionado, ModoFormulario.Editar);
                    frm.ShowDialog();
                    CargarDatos();
                    break;

                case "Desarchivar":
                    DialogResult resultado = MessageBox.Show($"¿Esta seguro de desarchivar el cliente {clienteSeleccionado.Nombre}?", "Desarchivar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(resultado == DialogResult.Yes)
                    {
                        repo.DesarchivarCliente(clienteSeleccionado.idCliente);
                        MessageBox.Show("Cliente desarchivado con exito", "Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    break;
            }

        }
    }
}
