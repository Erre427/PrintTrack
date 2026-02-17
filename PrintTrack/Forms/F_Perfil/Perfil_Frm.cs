using Microsoft.Win32;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PrintTrack.Forms.F_Perfil
{
    public partial class Perfil_Frm : Form
    {
        Usuarios usuarioactual;
        UsuarioRepositorio repository = new UsuarioRepositorio();
        RegistroTurnosRepositorio repositorioTurnos = new RegistroTurnosRepositorio();
        private int estadoTurno;
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
            estadoTurno = repositorioTurnos.ObtenerEstadoTurno(Sesion.idRegistroTurno);

            ObtenerFoto();
            txtNombreCompleto.Text = usuarioactual.NombreCompleto;
            txtNombreUsuario.Text = usuarioactual.NombreAlias;
            txtTelefono.Text = usuarioactual.Telefono;
            txtEmail.Text = usuarioactual.Email;
            lblUltimoAcceso.Text = usuarioactual.UltimoLogin.HasValue ? usuarioactual.UltimoLogin.Value.ToString("g") : "Primera Vez";

            ActualizarUI(estadoTurno);
            

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

        private void btnIniciarTurno_Click(object sender, EventArgs e)
        {
            string horaInicio = DateTime.Now.ToString("hh:mm:ss");
            try
            {
                RegistroTurnosRepositorio nuevoTurno = new RegistroTurnosRepositorio();
                nuevoTurno.RegistrarTurno(usuarioactual.idUsuarios, 1);
                Sesion.idRegistroTurno = nuevoTurno.ConsultaRegistro(usuarioactual.idUsuarios); // Actualiza el registro
                MessageBox.Show($"Turno Iniciado a las: {horaInicio}");
                CargarDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinTurno_Click(object sender, EventArgs e)
        {
            string horaFinal = DateTime.Now.ToString("hh:mm:ss");
            try
            {
                RegistroTurnosRepositorio nuevoTurno = new RegistroTurnosRepositorio();
                nuevoTurno.FinalizarTurno(Sesion.idRegistroTurno);
                Sesion.idRegistroTurno = 0; // Actualiza el registro
                MessageBox.Show($"Turno Finalizado a las: {horaFinal}");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigurarControles(string texto, bool btnIniciar, bool btnFin)
        {
            lblEstado.Text = texto;
            btnIniciarTurno.Enabled = btnIniciar;
            btnFinTurno.Enabled = btnFin;
        }

        private void ActualizarUI(int estadoActual)
        {
            switch (estadoActual)
            {
                case (int)TipoTurnos.Libre:
                    ConfigurarControles("Libre", true, false);
                    break;
                case (int)TipoTurnos.EnTurno:
                    ConfigurarControles("En Turno", false, true);
                    break;
                case (int)TipoTurnos.EnDescanso:
                    ConfigurarControles("En descanso", true, false);
                    break;
            }
        }
    }
}
