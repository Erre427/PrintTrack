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

namespace PrintTrack.Forms.F_Configuracion
{
    public partial class ClaveNueva_Frm : Form
    {

        UsuarioRepositorio repositorio = new UsuarioRepositorio();
        Usuarios usuarioActual;
        private ModoFormulario modo;
        public ClaveNueva_Frm(Usuarios usuarioActual, ModoFormulario modo)
        {
            this.usuarioActual = usuarioActual;
            this.modo = modo;
            InitializeComponent();
        }

        private void ClaveNueva_Frm_Load(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ModoFormulario.NuevoUusuario:
                    lblTitulo.Text = "Por seguridad, cambie su contraseña" + Environment.NewLine +
                        "a una nueva, esto por ser nuevo usuario.";
                    break;

                case ModoFormulario.Editar:
                    lblTitulo.Text = "Cambie su contraseña actual" + Environment.NewLine +
                        "por una nueva.";
                    break;
            }
            lblError.Visible = false;
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevaClave.Text == txtConfirmarClave.Text)
                {
                    repositorio.ActualizarClave(usuarioActual.idUsuarios, txtConfirmarClave.Text);
                    MessageBox.Show("Contraseña cambiada con exito","Nueva Contraseña",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    lblError.Visible = true;
                    txtNuevaClave.Clear();
                    txtConfirmarClave.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNuevaClave_TextChange(object sender, EventArgs e)
        {
            btnGuardar.Enabled = !string.IsNullOrWhiteSpace(txtNuevaClave.Text) &&
                !string.IsNullOrWhiteSpace(txtConfirmarClave.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
