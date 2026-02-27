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

namespace PrintTrack.Forms.F_Caja
{
    public partial class CajaFrm : Form
    {
        ProductoRepositorio repo = new ProductoRepositorio();
        List<Productos> listaProductos = new List<Productos>();
        public CajaFrm()
        {
            InitializeComponent();
        }

        private void CajaFrm_Load(object sender, EventArgs e)
        {
            ConfigurarBuscador();
        }

        private void AgregarProducto(int idProducto, string SKU, string nombre, decimal precio)
        {
            // Leemos la cantidad del control (el cuadrito que pusiste arriba)
            // Si está en 0, por defecto agregamos 1.
            int cantidadAAgregar = numCantidad.Value > 0 ? Convert.ToInt32(numCantidad.Value) : 1;

            bool existe = false;
            foreach (DataGridViewRow fila in dgvTicket.Rows)
            {
                // Asegúrate de tener una columna oculta llamada "idProducto"
                if (fila.Cells["idProducto"].Value != null && Convert.ToInt32(fila.Cells["idProducto"].Value) == idProducto)
                {
                    // Si ya existe, le sumamos la cantidad
                    int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    fila.Cells["Cantidad"].Value = cantidadActual + cantidadAAgregar;

                    // Recalculamos el subtotal de esa fila
                    fila.Cells["Subtotal"].Value = (cantidadActual + cantidadAAgregar) * precio;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                // CREAMOS LA FILA DE FORMA SEGURA
                int indiceFila = dgvTicket.Rows.Add(); // Agrega fila vacía y obtenemos su índice
                DataGridViewRow nuevaFila = dgvTicket.Rows[indiceFila];

                // Asignamos por el NOMBRE de la columna (¡Verifica que se llamen así!)
                nuevaFila.Cells["idProducto"].Value = idProducto;
                nuevaFila.Cells["SKU"].Value = SKU;
                nuevaFila.Cells["Nombre"].Value = nombre;
                nuevaFila.Cells["Cantidad"].Value = cantidadAAgregar;
                nuevaFila.Cells["Subtotal"].Value = cantidadAAgregar * precio;
            }

            // Regresamos el control de cantidad a 1 para el siguiente escaneo (opcional pero recomendado)
            numCantidad.Value = 1;

            // Calculamos el Total
            CalcularTotalCobro();
        }
        private void CalcularTotalCobro()
        {
            decimal total = 0;

            // Sumamos todos los subtotales del ticket
            foreach (DataGridViewRow fila in dgvTicket.Rows)
            {
                if (fila.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                }
            }

            // Actualizamos tus Labels (Asegúrate de cambiar los nombres por los tuyos)
            lblTotal.Text = total.ToString("C2"); // Formato de moneda: $ 1,000.00

        }

        private void ConfigurarBuscador()
        {
            listaProductos = repo.ObtenerProductos();

            AutoCompleteStringCollection coleccionCompletado = new AutoCompleteStringCollection();

            foreach (var prod in listaProductos)
            {
                if (!string.IsNullOrEmpty(prod.Nombre))
                    coleccionCompletado.Add(prod.Nombre);

                if (!string.IsNullOrEmpty(prod.SKU))
                    coleccionCompletado.Add(prod.SKU);
            }

            txtBuscar.AutoCompleteCustomSource = coleccionCompletado;

            txtBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificamos si la tecla presionada fue ENTER
            if (e.KeyCode == Keys.Enter)
            {
                // Evitamos el molesto sonido de "ding" de Windows
                e.SuppressKeyPress = true;

                string textoBusqueda = txtBuscar.Text.Trim();

                // Si está vacío, no hacemos nada
                if (string.IsNullOrEmpty(textoBusqueda)) return;

                // Buscamos en nuestra lista en memoria si hay un producto que coincida
                // exactamente con el Nombre o con el SKU escrito
                var productoEncontrado = listaProductos.FirstOrDefault(p =>
                    p.Nombre.Equals(textoBusqueda, StringComparison.OrdinalIgnoreCase) ||
                    p.SKU == textoBusqueda);

                if (productoEncontrado != null)
                {
                    // ¡LO ENCONTRÓ! Lo mandamos al método que hicimos en el paso anterior
                    // Asegúrate de que los nombres de las propiedades coincidan con tu clase Productos
                    AgregarProducto(
                        productoEncontrado.idProducto,
                        productoEncontrado.SKU,
                        productoEncontrado.Nombre,
                        productoEncontrado.PrecioVenta // O PrecioVenta, como lo tengas en tu clase
                    );

                    // Limpiamos el buscador y lo dejamos listo para el siguiente producto
                    txtBuscar.Text = "";
                    txtBuscar.Focus();
                }
                else
                {
                    // Si el cajero escribió algo que no existe
                    MessageBox.Show("Producto no encontrado o agotado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscar.SelectAll(); // Seleccionamos el texto erróneo para que lo borre rápido
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
