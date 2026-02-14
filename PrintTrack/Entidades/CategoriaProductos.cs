using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class CategoriaProductos
    {
        public int idCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public override string ToString()
        {
            return this.NombreCategoria;
        }
    }
}
