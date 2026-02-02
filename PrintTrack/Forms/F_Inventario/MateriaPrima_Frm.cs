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

namespace PrintTrack.Forms.F_Inventario
{
    public partial class MateriaPrima_Frm : Form
    {
        MateriaPrimaRepositorio repo = new MateriaPrimaRepositorio();
        List<MateriaPrima> listaMateriales = new List<MateriaPrima>();

        public MateriaPrima_Frm()
        {
            InitializeComponent();
        }

        private void MateriaPrima_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            
            dgvMateriaPrima.AutoGenerateColumns = false;
            listaMateriales = repo.ObtenerLista();


            listaMateriales = listaMateriales.OrderByDescending(c => c.idMateriaPrima).ToList();
            dgvMateriaPrima.DataSource = listaMateriales;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMaterial_MateriaPrima_Frm frm = new NuevoMaterial_MateriaPrima_Frm(null,ModoFormulario.Crear);
            frm.ShowDialog();
            CargarDatos();
        }

        private void dgvMateriaPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            MateriaPrima materialSeleccionado = (MateriaPrima)dgvMateriaPrima.Rows[e.RowIndex].DataBoundItem;

            switch (dgvMateriaPrima.Columns[e.ColumnIndex].Name)
            {
                case "Editar":
                    NuevoMaterial_MateriaPrima_Frm frm = new NuevoMaterial_MateriaPrima_Frm(materialSeleccionado, ModoFormulario.Editar);
                    frm.ShowDialog();
                    CargarDatos();
                    break;

                case "Entrada":
                    Entrada_MateriaPrima_Frm frmEntrada = new Entrada_MateriaPrima_Frm(materialSeleccionado.idMateriaPrima);
                    frmEntrada.ShowDialog();
                    CargarDatos();
                    break;
            }
        }

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
                var resultado = listaMateriales.Where(c => c.Nombre.ToLower().Contains(textoBuscar) || c.Proveedor.Nombre.ToLower().Contains(textoBuscar)).ToList();

                dgvMateriaPrima.DataSource = resultado;
            }
        }
    }
}
