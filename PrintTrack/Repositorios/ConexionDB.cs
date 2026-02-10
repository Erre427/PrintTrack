using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class ConexionDB
    {

        // Metodo para devolver la conexion a la base de datos y ahorrar codigo en los repositorios
        public static MySqlConnection ObtenerConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            return new MySqlConnection(connectionString);
        }
    }
}
