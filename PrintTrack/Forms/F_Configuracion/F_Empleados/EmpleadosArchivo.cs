using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintTrack.Repositorios;
using PrintTrack.Entidades;
using PrintTrack.Entidades.Enums;

namespace PrintTrack.Forms.F_Configuracion.F_Empleados
{
    public partial class EmpleadosArchivo : Form
    {
        UsuarioRepositorio repoEmpleados = new UsuarioRepositorio();
        List<Usuarios> listaEmpleados = new List<Usuarios>();

        public EmpleadosArchivo()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dgvEmpleadosArchivados.AutoGenerateColumns = false;

            listaEmpleados = repoEmpleados.ObtenerUsuariosArchivados();
            dgvEmpleadosArchivados.DataSource = listaEmpleados;
        }   

        private void EmpleadosArchivo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscar.Text.ToLower();

            if (String.IsNullOrEmpty(textoBuscar))
            {
                CargarDatos();
            }
            else
            {
                var resultado = listaEmpleados.Where(c => c.NombreCompleto.ToLower().Contains(textoBuscar) || c.NombreAlias.ToLower().Contains(textoBuscar)
                || c.Telefono.ToLower().Contains(textoBuscar) || c.Roles.Tipo.ToLower().Contains(textoBuscar)
                ).ToList();

                dgvEmpleadosArchivados.DataSource = resultado;
            }
        }

        private void dgvEmpleadosArchivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Usuarios UsuarioSeleccionado = (Usuarios)dgvEmpleadosArchivados.Rows[e.RowIndex].DataBoundItem;

            switch (dgvEmpleadosArchivados.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":
                    EmpleadosDetalles frmDetalles = new EmpleadosDetalles(UsuarioSeleccionado,ModoFormulario.Editar);
                    frmDetalles.ShowDialog();
                    CargarDatos();
                    break;

                case "Desarchivar":

                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea desarchivar/dar de alta este empleado?", "Confirmar desarchivado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(resultado == DialogResult.Yes)
                    {
                        repoEmpleados.DesarchivarEmpleado(UsuarioSeleccionado.idUsuarios);
                        MessageBox.Show("Empleado desarchivado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }

                    break;
            }



        }
    }
}
