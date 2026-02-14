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

namespace PrintTrack.Forms.F_Inventario
{
    public partial class Inventario_Frm : Form
    {
        MenuFrm menu;
        ProductoRepositorio repo = new ProductoRepositorio();
        CategoriasRepositorio repoCategorias = new CategoriasRepositorio();
        List<Productos> listaProductos = new List<Productos>();
        List<CategoriaProductos> listaCategorias = new List<CategoriaProductos>();
        public Inventario_Frm(MenuFrm menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores_Frm proveedores = new Proveedores_Frm();
            proveedores.ShowDialog();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new MateriaPrima_Frm());
        }

        private void Inventario_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRegEntradas_Click(object sender, EventArgs e)
        {
            Registro_Entradas_Frm frm = new Registro_Entradas_Frm();
            frm.ShowDialog();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            nuevoProducto frm = new nuevoProducto();
            frm.ShowDialog();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProductos.AutoGenerateColumns = false;
            listaProductos = repo.ObtenerProductos();

            listaProductos = listaProductos.OrderByDescending(c => c.idProducto).ToList();
            dgvProductos.DataSource = listaProductos;

            CargarCategorias();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias_Frm frm = new Categorias_Frm();
            frm.ShowDialog();
        }

        private void CargarCategorias()
        {
            bool mostrarID0 = true;
            listaCategorias = repoCategorias.GetCategorias(mostrarID0);

            cmbCategorias.DataSource = listaCategorias;
            cmbCategorias.DisplayMember = "NombreCategoria";
            cmbCategorias.ValueMember = "idCategoria";
        }

        private void cmbCategorias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idCategoriaSeleccionada = 0;

            if (cmbCategorias.SelectedValue != null)
            {
                idCategoriaSeleccionada = Convert.ToInt32(cmbCategorias.SelectedValue);
            }
            if (idCategoriaSeleccionada == 0)
            {
                dgvProductos.DataSource = listaProductos;
            }
            else
            {
                var listaFiltrada = listaProductos
                                    .Where(x => x.Categoria.idCategoria == idCategoriaSeleccionada)
                                    .ToList();

                dgvProductos.DataSource = listaFiltrada;
            }
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
                var resultado = listaProductos.Where(c => c.Nombre.ToLower().Contains(textoBuscar) || c.SKU.ToLower().Contains(textoBuscar)).ToList();

                dgvProductos.DataSource = resultado;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Productos productoSeleccionado = (Productos)dgvProductos.Rows[e.RowIndex].DataBoundItem;

            switch (dgvProductos.Columns[e.ColumnIndex].Name)
            {
                case "Detalles":

                    break;
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
