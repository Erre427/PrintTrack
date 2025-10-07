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
    public partial class NuevoCliente_Frm : Form
    {
        ClientesRepositorio repo = new ClientesRepositorio();
        public NuevoCliente_Frm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes nuevoCliente = new Clientes
                {
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Descripcion = txtDescripcion.Text
                };

                if(String.IsNullOrEmpty(txtNombre.Text)|| String.IsNullOrEmpty(txtTelefono.Text))
                {
                    throw new Exception("Minimo se requiere un nombre y numero de telefono!");
                }

                bool exito = repo.AgregarCliente(nuevoCliente);

                if (exito)
                {
                    MessageBox.Show("Cliente Agrego con exito!");
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al registrar el cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
