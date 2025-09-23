using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTrack.Repositorios
{
    internal class UsuarioRepositorio
    {
        public Usuarios Login(string alias, string contraseña)
        {
            using(MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT u.idUsuarios, u.NombreCompleto, u.NombreAlias,u.Clave, " +
                    "r.idRoles, r.Tipo,u.UltimoLogin " +
                    "FROM Usuarios u " +
                    "INNER JOIN Roles r ON u.Roles = r.idRoles " +
                    "WHERE NombreAlias = @Alias AND Clave = @contraseña";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Alias", alias);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                conexion.Open();
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuarios usuarios = new Usuarios
                            {
                                idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                NombreAlias = reader["NombreAlias"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Roles = new Roles
                                {
                                    idRoles = Convert.ToInt32(reader["idRoles"]),
                                    Tipo = reader["Tipo"].ToString()
                                },
                                UltimoLogin = reader["UltimoLogin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["UltimoLogin"])
                            };
                            reader.Close();

                            string updateDateQuery = "UPDATE usuarios SET UltimoLogin = NOW() WHERE idUsuarios = @id";
                            using (MySqlCommand updateDateCmd = new MySqlCommand(updateDateQuery, conexion))
                            {
                                updateDateCmd.Parameters.AddWithValue("@id",usuarios.idUsuarios);
                                updateDateCmd.ExecuteNonQuery();
                            }
                            return usuarios;
                        }
                    }
 
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


                return null;

            }
        }



    }
}
