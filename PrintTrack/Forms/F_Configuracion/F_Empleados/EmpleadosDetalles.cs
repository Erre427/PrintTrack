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
    
    // Formulario para ver, crear y editar los detalles de un empleado.
    // - Muestra y edita propiedades de la entidad Usuarios.
    // - Usa RolesRepository para obtener la lista de roles.
    // - Usa UsuarioRepositorio para persistir cambios en la base de datos.
    // - Maneja la foto del usuario como un arreglo de bytes (byte[]), normalmente en formato JPEG.
    public partial class EmpleadosDetalles : Form
    {
        // Variables e instancias principales
        private Usuarios usuarioActual;
        RolesRepository repoRoles = new RolesRepository();
        UsuarioRepositorio usuarioRepo = new UsuarioRepositorio();
        pantallaCarga carga = new pantallaCarga();
        private ModoFormulario modo;

        // Inicializa una nueva instancia del formulario con el usuario y el modo (Crear/Editar).
        // usuarioActual: Instancia de Usuarios a mostrar o editar. Puede ser null al crear.
        // modo: Modo del formulario. Determina el flujo (Crear o Editar).
        public EmpleadosDetalles(Usuarios usuarioActual, ModoFormulario modo)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            this.modo = modo;
        }

        // Manejador del botón Guardar. Decide entre crear o editar según el modo.
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                switch (modo)
                {
                    case ModoFormulario.Crear:
                        carga.Show();
                        await Task.Run(() => RegistrarNuevoEmpleado());
                        CerrarPantallaCarga();

                        MessageBox.Show(this,"Empleado creado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        this.Dispose();
                        break;

                    case ModoFormulario.Editar:
                        DialogResult opc = MessageBox.Show($"¿Esta seguro de editar los datos del empleado {usuarioActual.NombreCompleto}?", "Editar informacion empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
                        if(opc == DialogResult.Yes)
                        {
                            carga.Show();
                            await Task.Run(() => EditarEmpleado());
                            CerrarPantallaCarga();

                            MessageBox.Show(this,"Empleado editado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    break;
                }


            }
            catch(Exception ex)
            {
                CerrarPantallaCarga();
                MessageBox.Show(this,ex.Message);
            }
            finally
            {
                this.Enabled = true;
                this.Activate();
                this.Focus();
            }
            
        }

        // Abre un diálogo para seleccionar una imagen y la carga en el control de imagen.
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
      

        // Marca que hay cambios no guardados y habilita botones correspondientes.
        private void CambiosNoGuardados(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        // Inicialización al cargar el formulario. Configura la UI según el modo.
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

        

        // Convierte el arreglo de bytes de la propiedad usuarioActual.Foto a Image
        // y la asigna al control pbxFoto. Realiza una copia segura para evitar problemas GDI+.
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

        // Valida campos y actualiza los datos del empleado en la base de datos.
        // Construye un objeto Usuarios y llama a UsuarioRepositorio.ActualizarEmpleado.
        private void EditarEmpleado()
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
                            usuarioActual = datosNuevos;
                            CargarDatosTxt();
                            DeshabilitarControles();
                        }
                        else
                        {
                            throw new Exception("Hubo un error");
                        }

                    }
        }
        // Valida campos y crea un nuevo empleado en la base de datos.
        // Genera una clave temporal, envía credenciales por correo y llama a UsuarioRepositorio.NuevoEmpleado.
        private void RegistrarNuevoEmpleado()
        {
            byte[] fotoBytes = null;
            ProtocoloEmail protocolemail = new ProtocoloEmail();
            

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

                if (!exito)
                {
                    MessageBox.Show("Hubo un error");
                }

        }

        // Genera una contraseña temporal segura.
        // longitud: Longitud de la contraseña (por defecto 10).
        // returns: Cadena aleatoria generada con un RNG criptográfico.
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

        // Deshabilita los controles de edición en el formulario.
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

        // Habilita los controles para permitir la edición.
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


        // Carga los datos de usuarioActual en los controles del formulario.
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

        // Carga la lista de roles desde el repositorio y la asigna al control dropRoles.
        private void CargarRoles()
        {
            var roles = repoRoles.ObtenerRoles();
            dropRoles.DataSource = roles;


            dropRoles.DisplayMember = "Tipo";
            dropRoles.ValueMember = "idRoles";
        }

        private void CerrarPantallaCarga()
        {
            carga.Close();
            carga.Dispose();
        }
    }
}
