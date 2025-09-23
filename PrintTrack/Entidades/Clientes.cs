using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    internal class Clientes
    {
        // Propiedades de la clase, basado en la entidad de la base de datos CLIENTES
        public int idCliente {  get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; } 
        public string Descripcion { get; set; }
    }
}
