using PrintTrack.Entidades;
using PrintTrack.Forms.F_Clientes;
using PrintTrack.Forms.F_Configuracion;
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
    public partial class MenuFrm : Form
    {
        private Usuarios usuario;
        
        public MenuFrm()
        {
            InitializeComponent();
        }

        // Metodo con los datos del usuario logeado
        public void UsuarioReciente(Usuarios usuario)
        {
            this.usuario = usuario;
        }

        // Carga del dashboard, 
        private void MenuFrm_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DashBoard(this,usuario));
            if(usuario.Roles.idRoles != 1 && usuario.Roles.idRoles != 0)
            {
                btnConfiguracion.Visible = false;
            }
            
        }

        // Metodo para abrir los formularios en el panel
        public void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                Form formAnterior = panelContenedor.Controls[0] as Form;
                if (formAnterior != null)
                {
                    formAnterior.Close();
                    formAnterior.Dispose();
                }
                panelContenedor.Controls.Clear();
            }

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();

            
        }

        // Cerrar sesion
        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        // Actualizar fecha y hora en tiempo real
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }


        // Metodos de cada boton para insertar los formularios en el panel
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DashBoard(this,usuario)); // se pasa como parametro el Form para que lo ubique el constructor
        }

        public void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesFrm());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Configuracion_Frm(this)); // se pasa como parametro el Form para que lo ubique el constructor
        }
    }
}
