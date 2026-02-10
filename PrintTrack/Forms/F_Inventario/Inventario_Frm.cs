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
        List<Productos> listaProductos = new List<Productos>();
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
        }
    }
}
