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

namespace PrintTrack.Forms.F_Configuracion.F_Empleados
{
    public partial class EmpleadosEnviarCorreos_Frm : Form
    {
        List<Usuarios> listaEmpleados = new List<Usuarios>();
        ProtocoloEmail protocolo = new ProtocoloEmail();
        public EmpleadosEnviarCorreos_Frm(List<Usuarios> listaEmpleados)
        {
            this.listaEmpleados = listaEmpleados;
            InitializeComponent();
        }

        private void EmpleadosEnviarCorreos_Frm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            listaEmpleados = listaEmpleados.OrderByDescending(c => c.idUsuarios).ToList();
            dgvEmpleados.DataSource = listaEmpleados;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {

            List<Usuarios> listaDestinatarios = new List<Usuarios>();
            pantallaCarga pantallaCarga = new pantallaCarga();

            
            try
            {
                dgvEmpleados.EndEdit();

                foreach (DataGridViewRow row in dgvEmpleados.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool estaMarcado = Convert.ToBoolean(row.Cells["seleccionar"].Value);

                    if (estaMarcado)
                    {
                        Usuarios empleadoSeleccionado = (Usuarios)row.DataBoundItem;

                        listaDestinatarios.Add(empleadoSeleccionado);
                    }
                }

                if (listaDestinatarios.Count > 0)
                {
                    this.Enabled = false;
                    pantallaCarga.Show();
                    await Task.Run(() => protocolo.AnuncioGeneral(listaDestinatarios, txtAsunto.Text, txtMensaje.Text));
                }

                else
                {
                    throw new Exception("No selecciono ningun empleado");
                }

                this.Activate();
                this.Focus();
                pantallaCarga.Close();
                MessageBox.Show("Correos mandados con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                pantallaCarga.Dispose();
                this.Enabled = true;
            }
            

            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
