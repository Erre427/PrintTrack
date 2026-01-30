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
    }
}
