using PrintTrack.Entidades;
using PrintTrack.Forms.F_Clientes;
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

        public MenuFrm(Usuarios usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DashBoard(this,usuario));
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
        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DashBoard(this,usuario)); // se pasa como parametro el Form para que lo ubique el constructor
        }

        public void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesFrm());
        }
    }
}
