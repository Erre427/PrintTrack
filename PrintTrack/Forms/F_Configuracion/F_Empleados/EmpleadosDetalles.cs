using PrintTrack.Entidades;
using PrintTrack.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using PrintTrack.Entidades.Enums;
using System.Management;
using Org.BouncyCastle.Tls;

namespace PrintTrack.Forms.F_Configuracion.F_Empleados
{
    
    public partial class EmpleadosDetalles : Form
    {
        private Usuarios usuarioActual;
        RolesRepository repoRoles = new RolesRepository();
        UsuarioRepositorio usuarioRepo = new UsuarioRepositorio();
        private ModoFormulario modo;

        public EmpleadosDetalles(Usuarios usuarioActual, ModoFormulario modo)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            this.modo = modo;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ModoFormulario.Crear:
                    RegistrarNuevoEmpleado();
                    break;

                case ModoFormulario.Editar:
                    EditarEmpleado();
                    break;
            }
        }

        private void btnActualizarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();
            explorador.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (explorador.ShowDialog() == DialogResult.OK)
            {
                using (var temp = Image.FromFile(explorador.FileName))
                {
                    pbxFoto.Image = new Bitmap(temp);
                }
            }
        }
      

        private void CambiosNoGuardados(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void EmpleadosDetalles_Load(object sender, EventArgs e)
        {
            if(modo == ModoFormulario.Crear)
            {
                this.Text = "Nuevo Empleado";
                lblTitulo.Text = "Registrar Nuevo Empleado";
                lblTextoUltimoAcceso.Visible = false;
                lblUltimoAcceso.Visible = false;

                CargarRoles();
                HabilitarControles();
            }
            else if(modo == ModoFormulario.Editar)
            {
                this.Text = "Editar Empleado";
                lblTitulo.Text = "Detalles";
                pnlModificar.Visible = true;
                btnGuardar.Visible = true;

                CargarDatosTxt();
                DeshabilitarControles();

                MessageBox.Show(usuarioActual.Foto?.Length.ToString() ?? "null");
                MessageBox.Show(pbxFoto.Image == null ? "SIN IMAGEN" : "IMAGEN CARGADA");

            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatosTxt();
            DeshabilitarControles();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            HabilitarControles();
            CargarDatosTxt();
        }

        

        public void ObtenerFoto()
        {
            if (usuarioActual.Foto != null && usuarioActual.Foto.Length > 0)
            {
                using (var ms = new MemoryStream(usuarioActual.Foto))
                {
                    // Copia segura en memoria (evita error GDI+ al volver a guardar)
                    pbxFoto.Image = new Bitmap(Image.FromStream(ms));
                }
            }
            else
            {
                pbxFoto.Image = null;
            }
        }

        private void EditarEmpleado()
        {
            DialogResult opc = MessageBox.Show($"¿Esta seguro de editar los datos del empleado {usuarioActual.NombreCompleto}?", "Editar informacion empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opc == DialogResult.Yes)
            {
                try
                {
                    if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtAlias.Text))
                    {
                        throw new Exception("No se permiten espacios en blanco (Nombre, Usuario, Contraseña)");
                    }

                    using (var ms = new MemoryStream())
                    {
                        if (pbxFoto.Image != null)
                        {
                            pbxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            usuarioActual.Foto = ms.ToArray();
                        }
                        else
                        {
                            usuarioActual.Foto = null;
                        }
                        Usuarios datosNuevos = new Usuarios
                        {
                            idUsuarios = usuarioActual.idUsuarios,
                            NombreCompleto = txtNombre.Text.Trim(),
                            NombreAlias = txtAlias.Text.Trim(),
                            Email = txtCorreo.Text.Trim(),
                            Roles = new Roles
                            {
                                idRoles = Convert.ToInt32(dropRoles.SelectedValue)
                            },
                            Telefono = txtTelefono.Text.Trim(),
                            Foto = ms.ToArray()
                        };

                        bool exito = usuarioRepo.ActualizarEmpleado(datosNuevos);

                        if (exito)
                        {
                            MessageBox.Show("Cambios echos con exito");
                            usuarioActual = datosNuevos;
                            CargarDatosTxt();
                            DeshabilitarControles();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void RegistrarNuevoEmpleado()
        {
            byte[] fotoBytes = null;
            ProtocoloEmail protocolemail = new ProtocoloEmail();
            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtAlias.Text))
                {
                    throw new Exception("No se permiten espacios en blanco (Nombre, Usuario, Contraseña)");
                }

                
                if (pbxFoto.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        pbxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fotoBytes = ms.ToArray();
                    }
                }

                string claveTemporal = GenerarClaveTemporal();

                Usuarios NuevoEmpleado = new Usuarios
                {
                    NombreCompleto = txtNombre.Text.Trim(),
                    NombreAlias = txtAlias.Text.Trim(),
                    Clave = claveTemporal,
                    Roles = new Roles
                    {
                        idRoles = Convert.ToInt32(dropRoles.SelectedValue)
                    },
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtCorreo.Text.Trim(),
                    Foto = fotoBytes
                };

                protocolemail.EnviarCredenciales(NuevoEmpleado.Email,NuevoEmpleado.Clave,NuevoEmpleado.NombreAlias);
                bool exito = usuarioRepo.NuevoEmpleado(NuevoEmpleado);

                if (exito)
                {
                    MessageBox.Show("Empleado registrado con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clase que genera una clave temporal a empleados nuevos
        public static string GenerarClaveTemporal(int longitud = 10)
        {
            const string caracteres = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789@$!%*?";
            var password = new char[longitud];

            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] data = new byte[longitud];

                rng.GetBytes(data);

                for (int i = 0; i < longitud; i++)
                {
                    password[i] = caracteres[data[i] % caracteres.Length];
                }
            }

            return new string(password);
        }

        private void DeshabilitarControles()
        {
            txtNombre.Enabled = false;
            txtAlias.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            dropRoles.Enabled = false;
            btnActualizarFoto.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void HabilitarControles()
        {
            txtNombre.Enabled = true;
            txtAlias.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            dropRoles.Enabled = true;
            btnActualizarFoto.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
        }


        private void CargarDatosTxt()
        {
            txtNombre.Text = usuarioActual.NombreCompleto.ToString();
            txtAlias.Text = usuarioActual.NombreAlias.ToString();
            txtTelefono.Text = usuarioActual.Telefono.ToString();
            txtCorreo.Text = usuarioActual.Email.ToString();

            if (usuarioActual.UltimoLogin == null)
                lblUltimoAcceso.Text = "---";
            else
                lblUltimoAcceso.Text = usuarioActual.UltimoLogin.ToString();

            CargarRoles();
            dropRoles.SelectedValue = usuarioActual.Roles.idRoles;
            ObtenerFoto();


        }

        private void CargarRoles()
        {
            var roles = repoRoles.ObtenerRoles();
            dropRoles.DataSource = roles;


            dropRoles.DisplayMember = "Tipo";
            dropRoles.ValueMember = "idRoles";
        }

    }
}
