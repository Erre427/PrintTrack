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

namespace PrintTrack.Forms.F_Inventario
{
    public partial class Proveedores_Frm : Form
    {
        private List<Proveedores> listaProveedores = new List<Proveedores>();
        private ProveedorRepositorio repo = new ProveedorRepositorio();
        public Proveedores_Frm()
        {
            InitializeComponent();
        }
        private void Proveedores_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvProveedores.AutoGenerateColumns = false;
            listaProveedores = repo.ObtenerProveedores();

            listaProveedores = listaProveedores.OrderByDescending(c => c.idProveedor).ToList();
            dgvProveedores.DataSource = listaProveedores;

            pnDatos.Enabled = false;
            btnCambios.Visible = false;
            btnGuardar.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnCambios.Visible = false;
            btnGuardar.Visible = true;
            VaciarTxt();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtNombre.Text))
                {
                    throw new Exception("Se necesita minimo un nombre para registrar al proveedor");
                }

                Proveedores nuevoProveedor = new Proveedores
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim()
                };

                this.Enabled = false;
                repo.RegistrarNuevo(nuevoProveedor);
                MessageBox.Show("Proveedor registrado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                this.Enabled = true;
                pnDatos.Enabled = false;
                btnGuardar.Visible = false;
                btnNuevo.Enabled = true;
                CargarDatos();
                VaciarTxt();
            }
        }

        private void VaciarTxt()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Proveedores proveedorSeleccionado = (Proveedores)dgvProveedores.Rows[e.RowIndex].DataBoundItem;

            switch (dgvProveedores.Columns[e.ColumnIndex].Name)
            {
                case "Cargar":
                    btnNuevo.Enabled = true;
                    pnDatos.Enabled = true;
                    btnCambios.Visible = true;
                    txtNombre.Text = proveedorSeleccionado.Nombre;
                    txtTelefono.Text = proveedorSeleccionado.Telefono;
                    txtDireccion.Text = proveedorSeleccionado.Direccion;
                    txtCorreo.Text = proveedorSeleccionado.Correo;
                    break;

                case "Archivar":
                    break;
            }
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
