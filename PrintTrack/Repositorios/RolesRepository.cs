using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PrintTrack.Entidades;

namespace PrintTrack.Repositorios
{
    // Clase repositorio para todo el manejo de los roles de la base de datos
    public class RolesRepository
    {
        // Metodo tipo Lista para obtener los roles disponibles de la base de datos
        public List<Roles> ObtenerRoles()
        {
            var lista = new List<Roles>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                // Query SQL ignorando el rol 0 (Propietario o dueño)
                string query = "SELECT idRoles, Tipo FROM Roles WHERE idRoles != 0";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Roles
                            {
                                idRoles = reader.GetInt32("idRoles"),
                                Tipo = reader.GetString("Tipo")
                            });
                        }
                    }
                }
                conn.Close();
            }
            return lista;
        }




    }
}
