using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    internal class movimiento_MateriaPrima
    {
        public int idMovimiento { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public string Referencia { get; set; }
        public string TipoMovimiento { get; set; }

        
    }
}
