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
    public partial class Registro_Entradas_Frm : Form
    {
        private MateriaPrimaRepositorio repo = new MateriaPrimaRepositorio();
        private List<movimiento_MateriaPrima> lista = new List<movimiento_MateriaPrima>();
        public Registro_Entradas_Frm()
        {
            InitializeComponent();
        }

        private void Registro_Entradas_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvRegistro.AutoGenerateColumns = false;
            lista = repo.ConsultaRegistros();


            lista = lista.OrderByDescending(c => c.idMovimiento).ToList();
            dgvRegistro.DataSource = lista;
        }   
    }
}
