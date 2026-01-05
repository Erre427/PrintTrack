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

namespace PrintTrack.Forms.F_Perfil
{
    public partial class NuevoNombre_Frm : Form
    {
        UsuarioRepositorio repository = new UsuarioRepositorio();
        private int idUsuario;
        public NuevoNombre_Frm(int idUsuario)
        {
            this.idUsuario = idUsuario;
            InitializeComponent();
        }

        private void NuevoNombre_Frm_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Actualizar nombre de usuario";
            lblError.Visible = false;
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNuevUsuario.Text != txtConfirmarUsuario.Text)
                {
                    lblError.Visible = true;
                }
                else
                {
                    bool usuarioExistente = repository.VerificadorUsuarioExistente(txtConfirmarUsuario.Text);

                    if (usuarioExistente)
                    {
                        MessageBox.Show("Este usuario ya esta registrado, intente ingresando otro nombre", "Nombre existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        repository.ActualizarNombreUsuario(idUsuario, txtConfirmarUsuario.Text);
                        MessageBox.Show("Nombre de usuario cambiado con exito", "Nuevo nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtConfirmarUsuario_TextChange(object sender, EventArgs e)
        {
            btnGuardar.Enabled = !string.IsNullOrWhiteSpace(txtConfirmarUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txtNuevUsuario.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
