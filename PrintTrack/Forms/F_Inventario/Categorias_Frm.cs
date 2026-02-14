using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using PrintTrack.Repositorios;
using PrintTrack.Entidades;

namespace PrintTrack.Forms.F_Inventario
{
    public partial class Categorias_Frm : Form
    {
        CategoriasRepositorio repo = new CategoriasRepositorio();
        List<CategoriaProductos> listaCategorias = new List<CategoriaProductos>();
        public Categorias_Frm()
        {
            InitializeComponent();
        }

        private void Categorias_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            bool mostrarID0 = false;
            dgvCategorias.AutoGenerateColumns = false;
            listaCategorias= repo.GetCategorias(mostrarID0);

            listaCategorias = listaCategorias.OrderByDescending(c => c.idCategoria).ToList();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nombreCategoria = Interaction.InputBox("Ingrese nombre de categoria a registrar:", "Registrar Categoria", "");

            try
            {
                if (String.IsNullOrEmpty(nombreCategoria))
                {
                    throw new Exception("Minimo ponga un nombre a la categoria");
                }
                else
                {
                    repo.AgregarCategoria(nombreCategoria);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
