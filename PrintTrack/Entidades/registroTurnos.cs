using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Entidades
{
    public class registroTurnos
    {
        public int idRegistro { get; set; }
        public Usuarios Usuario { get; set; }
        public int Estado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal TotalHoras { get; set; }

    }
}
