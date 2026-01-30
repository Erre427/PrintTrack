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
    public partial class Inventario_Frm : Form
    {
        MenuFrm menu;
        public Inventario_Frm(MenuFrm menu  )
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores_Frm proveedores = new Proveedores_Frm();
            proveedores.ShowDialog();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            menu.AbrirFormularioEnPanel(new MateriaPrima_Frm());
        }

        private void Inventario_Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
