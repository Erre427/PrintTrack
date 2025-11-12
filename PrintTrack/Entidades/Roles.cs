using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class Roles
    {
        // Propiedades de la clase, basado en la entidad de la base de datos ROLES
        public int idRoles {  get; set; }
        public string Tipo {  get; set; }

        public override string ToString()
        {
            return this.Tipo; 
        }

    }
}
