using PrintTrack.Entidades;
using PrintTrack.Repositorios;
using PrintTrack.Forms.F_Clientes;
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
    public partial class DashBoard : Form
    {
        private Usuarios usuario;
        private MenuFrm menu; // Se pasa el menu al constructor para identificarlo para usar el metodo de abrir el form
        public DashBoard(MenuFrm menu,Usuarios usuario)
        {
            this.menu = menu;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
            lblUsuario.Text = usuario.NombreCompleto.ToString(); // Label para el nombre del usuario
            lblUltimaSesion.Text = usuario.UltimoLogin.HasValue ? usuario.UltimoLogin.Value.ToString("g") : "Primera Vez"; // Ultima sesion del usuario
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void clientesBtn_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new ClientesFrm());
        }
    }
}
