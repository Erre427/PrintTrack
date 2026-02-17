using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTrack.Forms.F_Configuracion
{
    public partial class Configuracion_Frm : Form
    {
        private MenuFrm menu;
        public Configuracion_Frm(MenuFrm menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new EmpleadosFrm());
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new RegistroTurnos());
        }
    }
}
