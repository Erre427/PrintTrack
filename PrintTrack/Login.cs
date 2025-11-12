using PrintTrack.Entidades;
using PrintTrack.Entidades.Enums;
using PrintTrack.Forms;
using PrintTrack.Forms.F_Configuracion.F_Empleados;
using PrintTrack.Properties;
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

namespace PrintTrack
{
    public partial class Login : Form
    {
        private bool pboxOjoDown = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesionBtn_Click(object sender, EventArgs e)
        {
            string usuario = usuariotxt.Text;
            string contraseña = contraseñaTxt.Text;

            UsuarioRepositorio repo = new UsuarioRepositorio();
            Usuarios usuarioencontrado = repo.Login(usuario, contraseña);

            if (usuarioencontrado != null)
            {
                this.Hide();
                VerificarUsuario.SetUsuarioActual(usuarioencontrado);
                MenuFrm menu = new MenuFrm();
                menu.UsuarioReciente(usuarioencontrado);
                menu.Show();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboxOjo_MouseDown(object sender, MouseEventArgs e)
        {
            pboxOjoDown = true;
            pboxOjo.Image = Properties.Resources.ojo;
            if (contraseñaTxt.PasswordChar == '*')
            {
                contraseñaTxt.PasswordChar = '\0';
            }
        }

        private void pboxOjo_MouseUp(object sender, MouseEventArgs e)
        {
            pboxOjoDown = false;
            pboxOjo.Image = Properties.Resources.ojo_cerrado;
            if (contraseñaTxt.PasswordChar == '\0')
            {
                contraseñaTxt.PasswordChar = '*';
            }
        }

        private void usuariotxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                contraseñaTxt.Focus();
            }
        }

        private void contraseñaTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                iniciarSesionBtn_Click(sender, e);
            }
        }

        
    }


    
}
