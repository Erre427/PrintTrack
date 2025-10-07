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
    public partial class AdminLogin : Form
    {
        UsuarioRepositorio repositorio = new UsuarioRepositorio();
        public bool key;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            Usuarios usuarioActual = repositorio.Login(usuario,clave);
           
            if(usuarioActual != null && usuarioActual.Roles.idRoles == 1)
            {
                MessageBox.Show("Admin logueado");
                this.key = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
