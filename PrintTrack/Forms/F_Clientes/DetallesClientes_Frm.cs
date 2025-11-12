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
    public partial class DetallesClientes_Frm : Form
    {
        ClientesRepositorio repo = new ClientesRepositorio();
        private Clientes cliente;
        private ModoFormulario modo;
        public DetallesClientes_Frm(Clientes cliente, ModoFormulario modo)
        {
            this.modo = modo;
            this.cliente = cliente;
            InitializeComponent();
        }
        private void CargarDatos()
        {
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtEmail.Text = cliente.Email;
            txtDescripcion.Text = cliente.Descripcion;
        }
        private void DeshabilitarTxt()
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtDescripcion.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void HabilitarTxt()
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void NuevoCliente()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardar el nuevo cliente?", "Nuevo Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                    {
                        throw new Exception("Minimo se requiere un nombre y numero de telefono!");
                    }
                    Clientes nuevoCliente = new Clientes()
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim()
                    };

                    bool exito = repo.AgregarCliente(nuevoCliente);

                    if (exito)
                    {
                        MessageBox.Show("Cliente registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void EditarCliente()
        {
            DialogResult resultado = MessageBox.Show($"¿Desea editar el cliente? {cliente.Nombre}", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                Clientes clienteEditado = new Clientes()
                {
                    idCliente = cliente.idCliente,
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                bool exito = repo.EditarCliente(clienteEditado);

                if (exito)
                {
                    MessageBox.Show("Cliente editado con exito");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }


        }   

        private void DetallesClientes_Frm_Load(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ModoFormulario.Editar:
                    lblTitulo.Text = "Detalles";
                    this.Text = "Detalles del Cliente";
                    pnlModificar.Visible = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    CargarDatos();
                    break;

                case ModoFormulario.Crear:
                    this.Text = "Registrar un nuevo cliente";
                    lblTitulo.Text = "Nuevo Cliente";
                    HabilitarTxt();
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            HabilitarTxt();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ModoFormulario.Editar:
                    EditarCliente();
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = true;
                    DeshabilitarTxt();
                    break;

                case ModoFormulario.Crear:
                    NuevoCliente();
                    this.Close();
                    break;


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnModificar.Enabled = true;
            DeshabilitarTxt();
            CargarDatos();
        }
    }
}
