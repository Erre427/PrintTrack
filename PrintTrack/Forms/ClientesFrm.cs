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

namespace PrintTrack.Forms
{
    public partial class ClientesFrm : Form
    {
        
        private ClientesRepositorio repository = new ClientesRepositorio();
        private List<Clientes> listaClientes = new List<Clientes>();
        
        // Metodo limpia TextBoxes
        private void CleanTxt()
        {
            nombre_clienteTxt.Clear();
            email_clienteTxt.Clear();
            telefono_clienteTxt.Clear();
            descripcion_clienteTxt.Clear();
        }
        
        // Metodo para cargar los clientes en el DataGridView
        public void CargarClientes()
        {
            clientesDgv.AutoGenerateColumns = false;
            listaClientes = repository.ObtenerClientes();
            clientesDgv.DataSource = listaClientes;
        }

        public ClientesFrm()
        {
            InitializeComponent();
        }

        // Carga los clientes con el metodo al cargar el formulario
        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        // Borra los campos al hacer click
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            CleanTxt();
        }

        // Metodo de busqueda en el DataGridView
        private void txtBuscar_TextChange(object sender, EventArgs e)
        {
               
            string textBuscar = txtBuscar.Text.ToLower();

            if (string.IsNullOrEmpty(textBuscar))
            {
                clientesDgv.DataSource = null;
                clientesDgv.DataSource = listaClientes;
            }
            else
            {
                var resultado = listaClientes.Where(c => c.Nombre.ToLower().Contains(textBuscar)
                || c.Telefono.ToLower().Contains(textBuscar)).ToList();
                clientesDgv.DataSource= resultado;
            }
            
        }

        // Dar de alta un cliente al sistema
        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes nuevoCliente = new Clientes
                {
                    Nombre = nombre_clienteTxt.Text.Trim(),
                    Telefono = telefono_clienteTxt.Text.Trim(),
                    Descripcion = descripcion_clienteTxt.Text.Trim(),
                    Email = email_clienteTxt.Text.Trim(),
                };


                if (String.IsNullOrEmpty(nombre_clienteTxt.Text) || String.IsNullOrEmpty(telefono_clienteTxt.Text))
                {
                    throw new Exception("Para registrar un cliente minimo se pide NOMBRE y TELEFONO");
                }

                bool exito = repository.AgregarCliente(nuevoCliente);

                if (exito)
                {
                    MessageBox.Show("Nuevo cliente agregado con exito!");
                    CargarClientes();
                    CleanTxt();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error durante el proceso");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // ARCHIVAR cliente  (Con validacion de administrador con credenciales)
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(clientesDgv.SelectedRows.Count > 0)
            {
                
                bool tienePermiso = VerificarUsuario.AdminChecker();

                if (!tienePermiso)
                {
                    tienePermiso = VerificarUsuario.AuthAdmin();
                }

                if (tienePermiso)
                {
                    DialogResult confirmar = MessageBox.Show("Esta seguro de archivar el cliente seleccionado?",
                        "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(confirmar == DialogResult.Yes)
                    {
                        Clientes clienteSeleccionado = (Clientes)clientesDgv.SelectedRows[0].DataBoundItem;
                        bool flagModif = repository.ArchivarCliente(clienteSeleccionado.idCliente);

                        if (flagModif)
                        {
                            MessageBox.Show("Cliente Archivado con exito");
                            CargarClientes();
                            CleanTxt();
                        }
                        else
                        {
                            MessageBox.Show("Error al Archivar el Cliente");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada");
                    }
                }

                else
                {
                    MessageBox.Show("OperacionFallida");
                }
            }
        }

        // Mostrar en los campos los datos de la fila seleccionada en el DGV
        private void clientesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Clientes clienteSeleccionado = (Clientes)clientesDgv.Rows[e.RowIndex].DataBoundItem;

                nombre_clienteTxt.Text = clienteSeleccionado.Nombre;
                telefono_clienteTxt.Text = clienteSeleccionado.Telefono;
                email_clienteTxt.Text = clienteSeleccionado.Email;
                descripcion_clienteTxt.Text = clienteSeleccionado.Descripcion;
            }
        }

        
    }
}
