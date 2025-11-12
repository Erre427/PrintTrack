using PrintTrack.Entidades;
using PrintTrack.Entidades.Enums;
using PrintTrack.Forms.F_Configuracion.F_Empleados;
using PrintTrack.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrintTrack.Forms.F_Configuracion
{
    public partial class EmpleadosFrm : Form
    {
        // Variables principales para el manejo de empleados
        private List<Usuarios> listaEmpleados = new List<Usuarios>();
        private UsuarioRepositorio repoUsuario = new UsuarioRepositorio();
        
        public EmpleadosFrm()
        { 
            InitializeComponent();
        }


        // Metodo para cargar los datos de la base de datos al DataGridView
        private void CargarDatos()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            listaEmpleados = repoUsuario.ObtenerUsuarios();

            listaEmpleados = listaEmpleados.OrderByDescending(c => c.idUsuarios).ToList();
            dgvEmpleados .DataSource = listaEmpleados;

        }
        // Evento Load del formulario para cargar los datos al iniciar
        private void EmpleadosFrm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Evento Click del boton Nuevo para abrir el formulario de detalles en modo Crear
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EmpleadosDetalles frm = new EmpleadosDetalles(null,ModoFormulario.Crear);
            frm.ShowDialog();
            CargarDatos();
        }

        // Evento TextChange del textbox de busqueda para filtrar los empleados en el DataGridView
        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            
            string textoBuscar = txtBuscar.Text.ToLower();

            // Si el texto de busqueda esta vacio, recargar todos los datos
            if (String.IsNullOrEmpty(textoBuscar))
            {
                CargarDatos();
            }
            // Filtrar la lista de empleados por nombre, alias, telefono o rol
            else
            {
                var resultado = listaEmpleados.Where(c => c.NombreCompleto.ToLower().Contains(textoBuscar) || c.NombreAlias.ToLower().Contains(textoBuscar)
                || c.Telefono.ToLower().Contains(textoBuscar) || c.Roles.Tipo.ToLower().Contains(textoBuscar)
                ).ToList();

                dgvEmpleados.DataSource = resultado;
            }
        }


        // Evento CellContentClick del DataGridView para manejar los botones de Detalles y Archivar
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Obtener el empleado seleccionado
            Usuarios UsuarioSeleccionado = (Usuarios)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;

            // Manejar segun la columna clickeada
            switch (dgvEmpleados.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":
                    EmpleadosDetalles detallesFrm = new EmpleadosDetalles(UsuarioSeleccionado,ModoFormulario.Editar);
                    detallesFrm.ShowDialog();
                    CargarDatos();
                    break;

                case "Archivar":
                    DialogResult warn = MessageBox.Show($"¿Esta seguro de archivar el empleado {UsuarioSeleccionado.NombreCompleto}?","Archivar Empleado",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(warn != DialogResult.No)
                    {
                        repoUsuario.ArchivarEmpleado(UsuarioSeleccionado.idUsuarios);
                        CargarDatos();
                    }
                    break;
            }
        }

        // Evento Click del boton Archivo para abrir el formulario de empleados archivados
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            EmpleadosArchivo frm = new EmpleadosArchivo();
            frm.ShowDialog();
            CargarDatos();
        }
    }
}
