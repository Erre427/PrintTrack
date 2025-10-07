using PrintTrack.Entidades;
using PrintTrack.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTrack.Repositorios
{
    // Clase estatica accesible sin constructor para establecer usuario actual y verificar si es administrador
    public static class VerificarUsuario
    {
        private static Usuarios _usuarioActual;

        // Establece usuario actual
        public static void SetUsuarioActual(Usuarios usuario)
        {
            _usuarioActual = usuario;
        }
        // Obtiene usuario actual
        public static Usuarios GetUsuarioActual()
        {
            return _usuarioActual;
        }


        // Verifica si el usuario actual es administrador, regresa false si no, regresa true si es admin
        public static bool AdminChecker()
        {
            if(_usuarioActual == null)
            {
                return false;
            }
            return _usuarioActual.Roles.idRoles == 1;
        }

        // Autenticacion de administrador y retorna true si las credenciales son correctas
        public static bool AuthAdmin()
        {
            AdminLogin adminLogin = new AdminLogin();
            return adminLogin.ShowDialog() == DialogResult.OK;
        }
    }
}
