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
using PrintTrack.Entidades.Enums;
using System.Windows.Forms.DataVisualization.Charting;

namespace PrintTrack.Forms
{
    public partial class DashBoard : Form
    {
        private Usuarios usuario;
        private int tipoTurno;
        private MenuFrm menu; // Se pasa el menu al constructor para identificarlo para usar el metodo de abrir el form
        private RegistroTurnosRepositorio turnosRepo = new RegistroTurnosRepositorio();
        public DashBoard(MenuFrm menu,Usuarios usuario)
        {
            this.menu = menu;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            ObtenerEstadoTurno();
            lblUsuario.Text = usuario.NombreCompleto.ToString(); // Label para el nombre del usuario
            lblUltimaSesion.Text = usuario.UltimoLogin.HasValue ? usuario.UltimoLogin.Value.ToString("g") : "Primera Vez"; // Ultima sesion del usuario
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if(tipoTurno != (int)TipoTurnos.EnTurno)
            {
                MessageBox.Show("Debes de estar en turno para realizar una venta!");
            }
        }
        private void clientesBtn_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new ClientesFrm());
        }

        private void ObtenerEstadoTurno()
        {
            
            tipoTurno = turnosRepo.ObtenerEstadoTurno(Sesion.idRegistroTurno);

            switch (tipoTurno)
            {
                case (int)TipoTurnos.Libre:
                    lblEstatus.Text = "Libre";
                    break;
                case (int)TipoTurnos.EnTurno:
                    lblEstatus.Text = "En Turno";
                    break;
                case (int)TipoTurnos.EnDescanso:
                    lblEstatus.Text = "En Descanso";
                    break;
            }
        }

        
    }
}
