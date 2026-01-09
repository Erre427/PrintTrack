using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class Receta
    {
        public Productos idProducto { get; set; }
        public MateriaPrima idMateriaPrima { get; set; }
        public decimal CantidadNeta { get; set; }
        public decimal ProcentajeMerma { get; set; }
        public decimal CostoUnitarioHistorico { get; set; }
        public string NotaAdicional { get; set; }

    }
}
