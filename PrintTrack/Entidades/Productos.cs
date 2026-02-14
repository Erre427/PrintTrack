using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class Productos
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal StockActual { get; set; }
        public CategoriaProductos Categoria { get; set; }
        public string SKU { get; set; }
        public int Estado { get; set; }


    }
}
 