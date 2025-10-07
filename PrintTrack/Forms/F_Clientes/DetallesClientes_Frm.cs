using PrintTrack.Entidades;
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
        private Clientes cliente;
        public DetallesClientes_Frm(Clientes cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
        }

        private void DetallesClientes_Frm_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtEmail.Text = cliente.Email;
            txtDescripcion.Text = cliente.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
