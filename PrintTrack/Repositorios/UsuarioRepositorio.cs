using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace PrintTrack.Repositorios
{
    internal class UsuarioRepositorio
    {

        // Login del usuario, obtiene todos sus datos con la ayuda del Inner Join
        public Usuarios Login(string alias, string contraseña)
        {
            using(MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT u.idUsuarios,u.NombreCompleto,u.NombreAlias,u.Clave,u.Telefono," +
                    "r.idRoles,r.Tipo,u.UltimoLogin,u.Estado " +
                    "FROM Usuarios u " +
                    "INNER JOIN Roles r ON u.Roles = r.idRoles " +
                    "WHERE NombreAlias = @Alias AND Estado = 1";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Alias", alias);

                conexion.Open();
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string hashAlmacenado = reader["Clave"].ToString();
                            bool valido = BCrypt.Net.BCrypt.Verify(contraseña,hashAlmacenado);

                            if (valido)
                            {
                                Usuarios usuarios = new Usuarios
                                {
                                    idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                                    NombreCompleto = reader["NombreCompleto"].ToString(),
                                    NombreAlias = reader["NombreAlias"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Estado = Convert.ToInt32(reader["Estado"]),
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
                                    updateDateCmd.Parameters.AddWithValue("@id", usuarios.idUsuarios);
                                    updateDateCmd.ExecuteNonQuery();
                                }
                                return usuarios;
                            }
                        }
                    }
 
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                // Si no se encuentra el usuario, devolver null
                return null;

            }
        }

        // Obtener una lista de usuarios de la base de datos, excluyendo al propietario (idRoles != 0)
        public List<Usuarios> ObtenerUsuarios()
        {
            var lista = new List<Usuarios>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT u.idUsuarios, u.NombreCompleto, u.NombreAlias,u.Telefono,u.Foto," +
                    "r.idRoles, r.Tipo,u.UltimoLogin,u.Estado " +
                    "FROM Usuarios u " +
                    "INNER JOIN Roles r ON u.Roles = r.idRoles " +
                    "WHERE Estado = 1 AND idRoles != 0";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                NombreAlias = reader["NombreAlias"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Estado = reader.GetInt32("Estado"),
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"],
                                Roles = new Roles
                                {
                                    idRoles = Convert.ToInt32(reader["idRoles"]),
                                    Tipo = reader["Tipo"].ToString()
                                },
                                UltimoLogin = reader["UltimoLogin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["UltimoLogin"])
                            });
                        }
                    }
                }
                conn.Close();
                return lista;
            }
        }

        public List<Usuarios> ObtenerUsuariosArchivados()
        {
            var lista = new List<Usuarios>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT u.idUsuarios, u.NombreCompleto, u.NombreAlias, u.Telefono,u.Foto," +
                    "r.idRoles, r.Tipo,u.UltimoLogin,u.Estado " +
                    "FROM Usuarios u " +
                    "INNER JOIN Roles r ON u.Roles = r.idRoles " +
                    "WHERE Estado = 0 AND idRoles != 0";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                NombreAlias = reader["NombreAlias"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Estado = reader.GetInt32("Estado"),
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"],
                                Roles = new Roles
                                {
                                    idRoles = Convert.ToInt32(reader["idRoles"]),
                                    Tipo = reader["Tipo"].ToString()
                                },
                                UltimoLogin = reader["UltimoLogin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["UltimoLogin"])
                            });
                        }
                    }
                }
                conn.Close();
                return lista;
            }
        }




        public bool ArchivarEmpleado(int idUsuario)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE USUARIOS SET ESTADO = 0 WHERE (idUsuarios = @id)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }
            }
        }

        public bool DesarchivarEmpleado(int idUsuario)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE USUARIOS SET ESTADO = 1 WHERE (idUsuarios = @id)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();
                    return filasAfectadas > 0;
                }
            }
        }


        public bool ActualizarEmpleado(Usuarios empleado)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE USUARIOS SET NombreCompleto = @nombre, " +
                    "NombreAlias = @Alias, Clave = @clave, Roles = @rol, Telefono = @telefono, Foto = @foto " +
                    "WHERE (idUsuarios = @id)";


                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", empleado.idUsuarios);
                    cmd.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
                    cmd.Parameters.AddWithValue("@alias", empleado.NombreAlias);
                    cmd.Parameters.AddWithValue("@rol", empleado.Roles.idRoles);
                    cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("@foto", (empleado.Foto != null && empleado.Foto.Length > 0) ? empleado.Foto : (object)DBNull.Value);


                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }


            }
        }

        public bool NuevoEmpleado(Usuarios NuevoEmpleado)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {

                string hash = BCrypt.Net.BCrypt.HashPassword(NuevoEmpleado.Clave);

                string query = "INSERT INTO USUARIOS (NombreCompleto,NombreAlias,Clave,Roles,Telefono,Foto) VALUES (@nombre,@alias,@clave,@rol,@telefono,@foto)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", NuevoEmpleado.NombreCompleto);
                    cmd.Parameters.AddWithValue("@alias", NuevoEmpleado.NombreAlias);
                    cmd.Parameters.AddWithValue("@clave", hash);
                    cmd.Parameters.AddWithValue("@rol", NuevoEmpleado.Roles.idRoles);
                    cmd.Parameters.AddWithValue("@telefono", NuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@foto", (NuevoEmpleado.Foto != null && NuevoEmpleado.Foto.Length > 0) ? NuevoEmpleado.Foto : (object)DBNull.Value);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }


            }
        }



    }
}
