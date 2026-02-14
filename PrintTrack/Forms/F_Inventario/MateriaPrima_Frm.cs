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

        private void dgvMateriaPrima_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Validamos que el Grid tenga filas y columnas
            if (dgvMateriaPrima.Columns["Stock"] == null || dgvMateriaPrima.Columns["StockMinimo"] == null) return;

            // 2. Obtenemos la fila actual que se está pintando
            var fila = dgvMateriaPrima.Rows[e.RowIndex];

            // 3. Obtenemos los valores (Usamos decimal para ser precisos)
            // El 'Try-Catch' o validación de nulos es vital aquí para que no truene
            if (fila.Cells["Stock"].Value != null && fila.Cells["StockMinimo"].Value != null)
            {
                decimal stockActual = Convert.ToDecimal(fila.Cells["Stock"].Value);
                decimal stockMinimo = Convert.ToDecimal(fila.Cells["StockMinimo"].Value);

                // 4. LA CONDICIÓN: ¿Estamos en aprietos?
                if (stockActual <= stockMinimo)
                {
                    // CASO CRÍTICO: Stock en 0 o negativo -> ROJO FUERTE
                    if (stockActual <= 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192); // Rojo suave
                        fila.DefaultCellStyle.ForeColor = Color.DarkRed; // Letras oscuras
                    }
                    // CASO ADVERTENCIA: Menor al mínimo pero mayor a 0 -> AMARILLO
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightYellow;
                        fila.DefaultCellStyle.ForeColor = Color.DarkGoldenrod;
                    }
                }
            }
        }
    }
}
