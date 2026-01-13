using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    public static class Sesion
    {
        public static int idUsuarioLogueado { get; set; } = 0;
        public static string NombreUsuario { get; set; } = "";

        public static int idRegistroTurno { get; set; } = 0;

    }
}
