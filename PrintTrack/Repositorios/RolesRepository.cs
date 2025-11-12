using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PrintTrack.Entidades;

namespace PrintTrack.Repositorios
{
    public class RolesRepository
    {
        public List<Roles> ObtenerRoles()
        {
            var lista = new List<Roles>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
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
