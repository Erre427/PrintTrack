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

namespace PrintTrack.Forms.F_Clientes
{
    public partial class EditarCliente_Frm : Form
    {
        ClientesRepositorio repo = new ClientesRepositorio();
        Clientes clienteActual;

        public EditarCliente_Frm(Clientes clienteActual)
        {
            this.clienteActual = clienteActual;
            InitializeComponent();
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult flagMsj = MessageBox.Show($"Esta seguro de modificar los datos del cliente: {clienteActual.Nombre}?",
                                "Modificar informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (flagMsj == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                    {
                        throw new Exception("Minimo se requiere un nombre y numero de telefono!");
                    }

                    Clientes nuevaInfo = new Clientes
                    {
                        idCliente = clienteActual.idCliente,
                        Nombre = txtNombre.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim()
                    };


                    bool exito = repo.EditarCliente(nuevaInfo);

                    if (exito)
                    {
                        MessageBox.Show("Cliente modificado con exito","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void EditarCliente_Frm_Load(object sender, EventArgs e)
        {
            txtNombre.Text = clienteActual.Nombre;
            txtTelefono.Text = clienteActual.Telefono;
            txtEmail.Text = clienteActual.Email;
            txtDescripcion.Text = clienteActual.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
