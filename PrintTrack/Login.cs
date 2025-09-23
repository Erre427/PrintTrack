using PrintTrack.Entidades;
using PrintTrack.Forms;
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

            if(usuarioencontrado != null)
            {
                this.Hide();
                MenuFrm menu = new MenuFrm(usuarioencontrado);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrectos");
            }
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
