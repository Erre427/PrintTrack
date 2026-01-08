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
    // Formulario para visualizar y gestionar los empleados archivados (Estado = 0).
    // Permite buscar entre los empleados archivados, ver detalles y desarchivar (dar de alta) empleados.
    public partial class EmpleadosArchivo : Form
    {
        // Repositorio encargado de las operaciones CRUD relacionadas con Usuarios.
        UsuarioRepositorio repoEmpleados = new UsuarioRepositorio();

        // Lista local que almacena los usuarios archivados obtenidos desde el repositorio.
        // Se usa como fuente para búsquedas y para vincular al DataGridView.
        List<Usuarios> listaEmpleados = new List<Usuarios>();

        // Constructor del formulario.
        public EmpleadosArchivo()
        {
            InitializeComponent();
        }

        // CargarDatos: obtiene los empleados archivados desde el repositorio y los asigna
        // al DataSource del DataGridView. También desactiva la generación automática de columnas
        // para usar las columnas definidas en el diseñador.
        private void CargarDatos()
        {
            dgvEmpleadosArchivados.AutoGenerateColumns = false;

            listaEmpleados = repoEmpleados.ObtenerUsuariosArchivados();
            dgvEmpleadosArchivados.DataSource = listaEmpleados;
        }   

        // Evento Load del formulario: carga los datos iniciales al abrir el formulario.
        private void EmpleadosArchivo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        // Evento de cambio de texto en el control de búsqueda.
        // Realiza búsqueda local sobre la lista ya cargada (listaEmpleados) y filtra por:
        // NombreCompleto, NombreAlias, Telefono o el Tipo del Rol.
        // Si el texto de búsqueda está vacío, recarga todos los datos.
        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
            string textoBuscar = txtBuscar.Text.ToLower();

            if (String.IsNullOrEmpty(textoBuscar))
            {
                // Si no hay texto, mostrar la lista completa de archivados.
                CargarDatos();
            }
            else
            {
                // Filtrado en memoria de la lista de empleados archivados.
                var resultado = listaEmpleados.Where(c => c.NombreCompleto.ToLower().Contains(textoBuscar) || c.NombreAlias.ToLower().Contains(textoBuscar)
                || c.Telefono.ToLower().Contains(textoBuscar) || c.Roles.Tipo.ToLower().Contains(textoBuscar)
                ).ToList();

                dgvEmpleadosArchivados.DataSource = resultado;
            }
        }

        // Maneja los clics en las celdas del DataGridView. Soporta acciones por columna:
        // - "Detalles": abre el formulario de detalles/edición del empleado seleccionado.
        // - "Desarchivar": solicita confirmación y, si se confirma, llama al repositorio para
        //                  desarchivar al empleado y recarga la lista.
        private void dgvEmpleadosArchivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar clics en encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Obtener la entidad Usuarios asociada a la fila seleccionada.
            Usuarios UsuarioSeleccionado = (Usuarios)dgvEmpleadosArchivados.Rows[e.RowIndex].DataBoundItem;

            switch (dgvEmpleadosArchivados.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":
                    // Abrir formulario de detalles en modo editar y recargar datos al cerrar.
                    EmpleadosDetalles frmDetalles = new EmpleadosDetalles(UsuarioSeleccionado,ModoFormulario.Editar);
                    frmDetalles.ShowDialog();
                    CargarDatos();
                    break;

                case "Desarchivar":

                    // Confirmación al usuario antes de realizar la acción irreversible de cambiar el estado.
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea desarchivar/dar de alta este empleado?", "Confirmar desarchivado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(resultado == DialogResult.Yes)
                    {
                        // Llamada al repositorio para actualizar el estado del empleado y notificación al usuario.
                        repoEmpleados.DesarchivarEmpleado(UsuarioSeleccionado.idUsuarios);
                        MessageBox.Show("Empleado desarchivado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }

                    break;
            }



        }
    }
}
