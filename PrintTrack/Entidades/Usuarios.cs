using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class Usuarios
    {

        // Propiedades de la clase, basado en la entidad de la base de datos USUARIOS
        public int idUsuarios { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreAlias { get; set; }
        public string Clave { get; set; }
        public Roles Roles { get; set; } // Propiedad de la clase Roles por el FK

        public DateTime? UltimoLogin { get; set; } // DateTime admite datos nulos (?)

    }
}
