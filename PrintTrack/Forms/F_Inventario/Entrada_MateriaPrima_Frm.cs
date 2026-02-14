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
    public partial class Entrada_MateriaPrima_Frm : Form
    {
        private int idMateriaPrima;
        private MateriaPrimaRepositorio repo = new MateriaPrimaRepositorio();
        public Entrada_MateriaPrima_Frm(int idMateriaPrima)
        {
            InitializeComponent();
            this.idMateriaPrima = idMateriaPrima;
        }

        private void Entrada_MateriaPrima_Frm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opc = MessageBox.Show("¿Esta seguro de registrar la entrada de materia prima?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opc == DialogResult.Yes)
                {
                    decimal cantidad = numCantidad.Value;
                    decimal costo = numCosto.Value;
                    string referencia = txtRecibo.Text;

                    if(cantidad <= 0)
                    {
                        throw new Exception("No se permiten valores negativos o numeros en cero");
                    }
                    repo.EntradaMateriaPrima(idMateriaPrima, cantidad, costo, referencia);

                    MessageBox.Show("Entrada de material registrada exitosamente","Exito Entrada",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Operacion cancelada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
