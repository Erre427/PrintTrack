using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class MateriaPrima
    {
        public int idMateriaPrima { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public decimal Stock { get; set; }
        public decimal StockMinimo { get; set; }
        public Proveedores Proveedor { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
