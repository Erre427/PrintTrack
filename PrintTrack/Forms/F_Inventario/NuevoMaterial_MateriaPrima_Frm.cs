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

namespace PrintTrack.Forms.F_Inventario
{
    public partial class NuevoMaterial_MateriaPrima_Frm : Form
    {
        private MateriaPrimaRepositorio repo = new MateriaPrimaRepositorio();
        private ProveedorRepositorio repoProveedor = new ProveedorRepositorio();
        private ModoFormulario modo;
        private MateriaPrima materialCargado;

        public NuevoMaterial_MateriaPrima_Frm(MateriaPrima materialCargado, ModoFormulario modo)
        {
            this.materialCargado = materialCargado;
            this.modo = modo;
            InitializeComponent();
        }

        private void NuevoMaterial_MateriaPrima_Frm_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            switch (modo)
            {
                case ModoFormulario.Crear:
                    ModoCrear();
                    break;

                case ModoFormulario.Editar:
                    ModoEditar();
                    break;
            }
        }

        private void DesactivarControles()
        {
            txtNombre.Enabled = false;
            pnlProveedor.Enabled = false;
            btnGuardar.Enabled = false;
            pnlEntrada.Enabled = false;
        }

        private void ActivarControles()
        {
            txtNombre.Enabled = true;
            pnlProveedor.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void CargarProveedores()
        {
            var roles = repoProveedor.ObtenerIDs();
            dropProveedores.DataSource = roles;


            dropProveedores.DisplayMember = "Nombre";
            dropProveedores.ValueMember = "idProveedor";
        }

        private void ModoCrear()
        {
            lblTitulo.Text = "Registrar nuevo material";
            pnlModificar.Visible = false;
        }

        private void ModoEditar()
        {
            CargarDatos();
            lblTitulo.Text = "Editar Material";
            pnlModificar.Visible = true;
            pnlInfo.Visible = false;
            btnGuardar.Location = new Point(244, 180);
            panel2.Size = new Size(659, 247);
            this.Size = new Size(699, 388);

            pnlProveedor.Enabled = false;
            pnlEntrada.Visible = false;
            pnlCheck.Visible = false;
            txtNombre.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void CargarDatos()
        {
            txtNombre.Text = materialCargado.Nombre;
            dropProveedores.Text = materialCargado.Proveedor.Nombre;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            ActivarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            DesactivarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (modo)
                {
                    case ModoFormulario.Crear:
                        NuevoMaterial();
                        break;

                    case ModoFormulario.Editar:
                        DialogResult opc = MessageBox.Show("¿Esta seguro de editar los datos del material?", "Editar informacion material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (opc == DialogResult.Yes)
                        {
                            EditarMateria();
                        }
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message);
            }
        }

        private void NuevoMaterial()
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(cmbUnidad.Text)
                                || String.IsNullOrEmpty(numStockMinimo.Text))
                {
                    throw new Exception("Todos los campos deben de ser llenados para registrar un material!");
                }

                if (checkEntrada.Checked)
                {
                    if (numCantidad.Value <= 0)
                    {
                        throw new Exception("No se permiten valores en cero o negativos en cantidad");
                    }

                    if (numCosto.Value < 0)
                    {
                        throw new Exception("El costo no puede ser negativo");
                    }

                }

                MateriaPrima nuevoMaterial = new MateriaPrima
                {
                    Nombre = txtNombre.Text,
                    Unidad = cmbUnidad.Text,
                    StockMinimo = numStockMinimo.Value,
                    Proveedor = new Proveedores
                    {
                        idProveedor = Convert.ToInt32(dropProveedores.SelectedValue)
                    }
                };

                int idNuevo = repo.RegistrarNuevo(nuevoMaterial);

                if (idNuevo > 0)
                {
                    if (checkEntrada.Checked)
                    {
                        decimal cantidadEntrada = numCantidad.Value;
                        decimal precioEntrada = numCosto.Value;
                        string referencia = txtRecibo.Text;

                        if (cantidadEntrada <= 0)
                        {
                            throw new Exception("No se permiten valores negativos o en cero");
                        }

                        bool exitoEntrada = repo.EntradaMateriaPrima(idNuevo, cantidadEntrada, precioEntrada, referencia);

                        if (exitoEntrada)
                        {
                            MessageBox.Show("Material registrado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Material registrado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    throw new Exception("Ocurrio un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void EditarMateria()
        {
            MateriaPrima materialEditado = new MateriaPrima
            {
                idMateriaPrima = materialCargado.idMateriaPrima,
                Nombre = txtNombre.Text,
                Proveedor = new Proveedores
                {
                    idProveedor = Convert.ToInt32(dropProveedores.SelectedValue)
                }
            };

            bool exito = repo.EditarMaterial(materialEditado);

            if (exito)
            {
                MessageBox.Show("Material editado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            else
            {
                throw new Exception("Ocurrio un error");
            }
        }

        private void checkEntrada_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            bool habilitar = checkEntrada.Checked;

            pnlEntrada.Enabled = habilitar;
        }
    }
}
