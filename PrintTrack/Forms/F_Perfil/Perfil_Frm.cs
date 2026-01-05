using PrintTrack.Entidades;
using PrintTrack.Entidades.Enums;
using PrintTrack.Forms.F_Configuracion;
using PrintTrack.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTrack.Forms.F_Perfil
{
    public partial class Perfil_Frm : Form
    {
        Usuarios usuarioactual;
        UsuarioRepositorio repository = new UsuarioRepositorio();

        public Perfil_Frm()
        {
            InitializeComponent();
        }

        
        private void Perfil_Frm_Load(object sender, EventArgs e)
        {
            usuarioactual = VerificarUsuario.GetUsuarioActual();

            btnGuardarCambios.Visible = false;
            btnFinTurno.Enabled = false;
            txtNombreCompleto.Enabled = false;
            txtEmail.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtTelefono.Enabled = false;



            CargarDatos();
        }

        private void CargarDatos()
        {
            usuarioactual = repository.ReloadUsuario(usuarioactual.idUsuarios);
            ObtenerFoto();
            txtNombreCompleto.Text = usuarioactual.NombreCompleto;
            txtNombreUsuario.Text = usuarioactual.NombreAlias;
            txtTelefono.Text = usuarioactual.Telefono;
            txtEmail.Text = usuarioactual.Email;
            lblUltimoAcceso.Text = usuarioactual.UltimoLogin.HasValue ? usuarioactual.UltimoLogin.Value.ToString("g") : "Primera Vez";
        }

        private void ObtenerFoto()
        {
            if (usuarioactual.Foto != null && usuarioactual.Foto.Length > 0)
            {
                using (var ms = new MemoryStream(usuarioactual.Foto))
                {
                    ms.Position = 0;
                    using (var imgTemp = Image.FromStream(ms))
                    {
                        pbImagen.Image = new Bitmap(imgTemp); // clon real
                    }
                }
            }
            else
            {
                pbImagen.Image = null;
            }
        }

        private void btnEditarClave_Click(object sender, EventArgs e)
        {
            ClaveNueva_Frm cambioClave = new ClaveNueva_Frm(usuarioactual, ModoFormulario.Editar);
            cambioClave.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            NuevoNombre_Frm nuevoNombre = new NuevoNombre_Frm(usuarioactual.idUsuarios);
            nuevoNombre.ShowDialog();
            CargarDatos();
        }
    }
}
