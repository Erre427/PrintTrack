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

namespace PrintTrack.Forms.F_Configuracion
{
    public partial class RegistroTurnos : Form
    {
        RegistroTurnosRepositorio repo = new RegistroTurnosRepositorio();
        UsuarioRepositorio repoUsuarios = new UsuarioRepositorio();
        List<UsuarioRepositorio> listaUsuarios = new List<UsuarioRepositorio>();
        List<registroTurnos> listaRegistros = new List<registroTurnos>();
        public RegistroTurnos()
        {
            InitializeComponent();
        }

        private void RegistroTurnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvTurnos.AutoGenerateColumns = false;
            listaRegistros = repo.ObtenerRegistros();

            listaRegistros = listaRegistros.OrderByDescending(c => c.idRegistro).ToList();
            dgvTurnos.DataSource = listaRegistros;

            cmbFiltroNombre.Enabled = false;
            dpFiltroFecha.Enabled = false;

            CargarEmpleados();
        }

        private void cmbFiltroNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (toggleNombre.Checked) AplicarFiltros();
        }

        private void dpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {
            if (toggleFecha.Checked) AplicarFiltros();
        }

        private void CargarEmpleados()
        {
            var lista = repoUsuarios.ObtenerUsuarios();

            lista.Insert(0, new Usuarios { idUsuarios = 0, NombreCompleto = "--- Todos los empleados ---" });

            cmbFiltroNombre.DataSource = lista;


            cmbFiltroNombre.DisplayMember = "NombreCompleto";
            cmbFiltroNombre.ValueMember = "idUsuarios";
        }

        private void toggleNombre_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            cmbFiltroNombre.Enabled = toggleNombre.Checked;
            AplicarFiltros();
        }

        private void toggleFecha_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            dpFiltroFecha.Enabled = toggleFecha.Checked;
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            // CORRECCIÓN 1: Validamos 'listaRegistros' (los turnos), no 'listaUsuarios'
            if (listaRegistros == null || !listaRegistros.Any()) return;

            // Empezamos con la lista completa de turnos
            var listaFiltrada = listaRegistros.AsEnumerable();

            // --- FILTRO 1: NOMBRE ---
            if (toggleNombre.Checked && cmbFiltroNombre.SelectedValue != null)
            {
                if (int.TryParse(cmbFiltroNombre.SelectedValue.ToString(), out int idUsuario))
                {
                    if (idUsuario > 0)
                    {
                        // CORRECCIÓN 2: Accedemos a la propiedad correcta x.Usuario.idUsuarios
                        listaFiltrada = listaFiltrada.Where(x => x.Usuario.idUsuarios == idUsuario);
                    }
                }
            }

            // --- FILTRO 2: FECHA ---
            if (toggleFecha.Checked)
            {
                // CORRECCIÓN 3: Usamos el nombre correcto del control 'dpFiltroFecha'
                DateTime fechaFiltro = dpFiltroFecha.Value.Date;

                listaFiltrada = listaFiltrada.Where(x =>
                    x.FechaInicio.HasValue &&
                    x.FechaInicio.Value.Date == fechaFiltro
                );
            }

            // Actualizamos el Grid
            dgvTurnos.DataSource = listaFiltrada.ToList();
        }
    }
}
