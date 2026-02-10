using PrintTrack.Entidades;
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

namespace PrintTrack.Forms.F_Inventario
{
    public partial class nuevoProducto : Form
    {
        MateriaPrimaRepositorio repoMateriales = new MateriaPrimaRepositorio();
        RecetaRepository repoReceta = new RecetaRepository();
        CategoriasRepositorio repoCategorias = new CategoriasRepositorio();
        ProductoRepositorio repoProducto = new ProductoRepositorio();
        List<MaterialesSeleccionados> listaMateriales = new List<MaterialesSeleccionados>();
        private class MaterialesSeleccionados
        {
            public int idMateriaPrima { get; set; }
            public string NombreMateriaPrima { get; set; }
            public decimal Cantidad { get; set; }

        }
        public nuevoProducto()
        {
            InitializeComponent();
        }

        private void nuevoProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            var Materiales = repoMateriales.ObtenerLista();
            cmbMateriales.DataSource = Materiales;

            cmbMateriales.DisplayMember = "Nombre";
            cmbMateriales.ValueMember = "idMateriaPrima";
        }

        private void CargarCategorias()
        {
            var Categorias = repoCategorias.GetCategorias();
            cmbCategorias.DataSource = Categorias;

            cmbCategorias.DisplayMember = "NombreCategoria";
            cmbCategorias.ValueMember = "idCategoria";
        }

        private void cmbMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMateriales.SelectedItem == null)
            {
                lblUnidad.Text = "..."; // O dejarlo vacío ""
                return;
            }

            // 2. Convertimos el item seleccionado a TU clase (MateriaPrima)
            // "Castear" significa decirle a C#: "Confía en mí, esto es una MateriaPrima"
            MateriaPrima materialSeleccionado = (MateriaPrima)cmbMateriales.SelectedItem;

            // 3. Escribimos la unidad en el Label
            lblUnidad.Text = materialSeleccionado.Unidad;
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            if (cmbMateriales.SelectedItem == null || numCantidad.Value <= 0)
            {
                MessageBox.Show("Seleccione un material valido y una cantidad mayor a 0");
                return;
            }

            MateriaPrima materialSeleccionado = (MateriaPrima)cmbMateriales.SelectedItem;


            decimal cantidad = numCantidad.Value;

            var itemExistente = listaMateriales.FirstOrDefault(x => x.idMateriaPrima == materialSeleccionado.idMateriaPrima);

            if (itemExistente != null)
            {
                // Si YA existe, solo sumamos la cantidad nueva a la que ya tenía
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                listaMateriales.Add(new MaterialesSeleccionados
                {
                    idMateriaPrima = materialSeleccionado.idMateriaPrima,
                    NombreMateriaPrima = materialSeleccionado.Nombre,
                    Cantidad = cantidad
                });
            }

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {

            dgvMateriales.AutoGenerateColumns = false;
            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = listaMateriales;

            if (dgvMateriales.Columns["idMateriaPrima"] != null)
            {
                dgvMateriales.Columns["idMateriaPrima"].Visible = false;
            }

            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMateriales.Columns[e.ColumnIndex].Name != "Eliminar")
            {
                return; // Si no es el botón, nos salimos y no hacemos nada
            }

            var borrarMaterial = (MaterialesSeleccionados)dgvMateriales.Rows[e.RowIndex].DataBoundItem;
            listaMateriales.Remove(borrarMaterial);

            ActualizarTabla();
        }

        private void GenerarSKU()
        {
            if (!checkSKUAutomatico.Checked)
            {
                return;
            }

            string categoria = cmbCategorias.Text.Trim().ToUpper();
            string nombre = txtNombre.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(nombre))
            {
                return;
            }

            string codigoCat = categoria.Substring(0, Math.Min(categoria.Length, 3));

            string nombreSinEspacios = nombre.Replace(" ", "");
            string codigoNom = "";

            if (nombreSinEspacios.Length > 0)
            {
                codigoNom = nombreSinEspacios.Substring(0, Math.Min(nombreSinEspacios.Length, 3));
            }

            Random rnd = new Random();
            string sufijo = rnd.Next(100, 999).ToString();

            txtSKU.Text = $"{codigoCat}-{codigoNom}-{sufijo}";
        }

        private void checkSKUAutomatico_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (checkSKUAutomatico.Checked)
            {
                txtSKU.Enabled = false;
                GenerarSKU();
            }
            else
            {
                txtSKU.Enabled = true;
                txtSKU.Text = "";
            }
        }

        private void txtNombre_TextChange(object sender, EventArgs e)
        {
            GenerarSKU();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarSKU();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaMateriales.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un material al producto.");
                    return;
                }

                if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtSKU.Text))
                {
                    MessageBox.Show("Complete el nombre y SKU del producto.");
                    return;
                }

                Productos nuevoProducto = new Productos
                {
                    Nombre = txtNombre.Text.Trim(),
                    PrecioVenta = numPrecioVenta.Value,
                    Categoria = new CategoriaProductos
                    {
                        idCategoria = Convert.ToInt32(cmbCategorias.SelectedValue),
                        NombreCategoria = cmbCategorias.Text
                    },
                    SKU = txtSKU.Text.Trim(),
                };

                long idProductoRegistrado = repoProducto.RegistrarNuevoProducto(nuevoProducto);

                foreach (var material in listaMateriales)
                {
                    Receta nuevaReceta = new Receta
                    {
                        idProducto = new Productos
                        {
                            idProducto = (int)idProductoRegistrado
                        },
                        CantidadNeta = material.Cantidad,
                        idMateriaPrima = new MateriaPrima
                        {
                            idMateriaPrima = material.idMateriaPrima,
                            Nombre = material.NombreMateriaPrima
                        },
                        NotaAdicional = txtNota.Text.Trim()
                    };

                    repoReceta.RegistrarReceta(nuevaReceta);
                }

                MessageBox.Show("Producto registrado exitosamente.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.Message);
            }
        }
    }
}
