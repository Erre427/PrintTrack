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
using System.Security.Cryptography;

namespace PrintTrack.Repositorios
{
    // Repositorio encargado de las operaciones CRUD y consultas relacionadas con la entidad Usuarios.
    // - Encapsula llamadas a la base de datos MySQL usando MySql.Data.
    // - Realiza mapeo entre filas del DB y objetos de dominio (Usuarios, Roles).
    internal class UsuarioRepositorio
    {

        // Login del usuario, obtiene todos sus datos con la ayuda del Inner Join
        // Devuelve la entidad Usuarios completa si las credenciales son válidas; actualiza UltimoLogin.
        public Usuarios Login(string alias, string contraseña)
        {
            using(MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT u.idUsuarios,u.NombreCompleto,u.NombreAlias,u.Clave,u.Telefono,u.Email,u.Foto," +
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
                                    Email = reader["Email"].ToString(),
                                    Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"],
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
        // Devuelve una lista de entidades Usuarios con su Rol asociado.
        public List<Usuarios> ObtenerUsuarios()
        {
            var lista = new List<Usuarios>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT u.idUsuarios, u.NombreCompleto, u.NombreAlias,u.Telefono,u.Foto,u.Email," +
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
                                Email = reader["Email"].ToString(),
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

        // Obtener los empleados archivados en la lista (Estado = 0)
        public List<Usuarios> ObtenerUsuariosArchivados()
        {
            var lista = new List<Usuarios>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT u.idUsuarios, u.NombreCompleto, u.NombreAlias, u.Telefono,u.Foto,u.Email," +
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
                                Email = reader["Email"].ToString(),
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


        // Archivar empleado en la base de datos (set Estado = 0)
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

        // Desarchivar empleado en la base de datos (set Estado = 1)
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


        // Actualizar datos del empleado en la base de datos
        // Asegúrate de pasar Roles.idRoles (int) en lugar de la entidad Roles completa.
        public bool ActualizarEmpleado(Usuarios empleado)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE USUARIOS SET NombreCompleto = @nombre, " +
                    "NombreAlias = @Alias, Roles = @rol, Telefono = @telefono, Foto = @foto, Email = @email " +
                    "WHERE (idUsuarios = @id)";


                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", empleado.idUsuarios);
                    cmd.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
                    cmd.Parameters.AddWithValue("@alias", empleado.NombreAlias);
                    cmd.Parameters.AddWithValue("@email", empleado.Email);
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

        // Nuevo empleado en la base de datos (Utilizando Hasheo a la contraseña)
        public bool NuevoEmpleado(Usuarios NuevoEmpleado)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                // Hasheo a la contraseña
                string hash = BCrypt.Net.BCrypt.HashPassword(NuevoEmpleado.Clave);

                string query = "INSERT INTO USUARIOS (NombreCompleto,NombreAlias,Clave,Roles,Telefono,Foto,Email) VALUES (@nombre,@alias,@clave,@rol,@telefono,@foto,@email)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", NuevoEmpleado.NombreCompleto);
                    cmd.Parameters.AddWithValue("@alias", NuevoEmpleado.NombreAlias);
                    cmd.Parameters.AddWithValue("@clave", hash);
                    cmd.Parameters.AddWithValue("@rol", NuevoEmpleado.Roles.idRoles);
                    cmd.Parameters.AddWithValue("@telefono", NuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@email", NuevoEmpleado.Email);
                    cmd.Parameters.AddWithValue("@foto", (NuevoEmpleado.Foto != null && NuevoEmpleado.Foto.Length > 0) ? NuevoEmpleado.Foto : (object)DBNull.Value);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }


            }
        }


        // Actualizar clave/contraseña de usuario
        public bool ActualizarClave(int idUsuario, string nuevaClave)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                // Hasheo de contraseña
                string hash = BCrypt.Net.BCrypt.HashPassword(nuevaClave);

                // Query SQL
                string query = "UPDATE USUARIOS SET Clave = @clave WHERE (idUsuarios = @id)";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clave", hash);
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }

            }
        }

        // Metodo para actualizar el nombre de usuario
        public bool ActualizarNombreUsuario(int idUsuario, string nuevoUsuario)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                // Query SQL
                string query = "UPDATE USUARIOS SET NombreAlias = @nuevo WHERE (idUsuarios = @id)";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nuevo", nuevoUsuario);
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }
            }
        }

        // Metodo para recargar los datos del usuario en tiempo real o cuando se invoque
        public Usuarios ReloadUsuario(int idUsuario)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT u.idUsuarios,u.NombreCompleto,u.NombreAlias,u.Clave,
                                u.Telefono,u.Email,u.Foto,
                                r.idRoles,r.Tipo,
                                u.UltimoLogin,u.Estado
                         FROM Usuarios u
                         INNER JOIN Roles r ON u.Roles = r.idRoles
                         WHERE u.idUsuarios = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                conexion.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuarios
                        {
                            idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                            NombreCompleto = reader["NombreCompleto"].ToString(),
                            NombreAlias = reader["NombreAlias"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Email = reader["Email"].ToString(),
                            Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"],
                            Estado = Convert.ToInt32(reader["Estado"]),
                            Roles = new Roles
                            {
                                idRoles = Convert.ToInt32(reader["idRoles"]),
                                Tipo = reader["Tipo"].ToString()
                            },
                            UltimoLogin = reader["UltimoLogin"] == DBNull.Value
                                            ? (DateTime?)null
                                            : Convert.ToDateTime(reader["UltimoLogin"])
                        };
                    }
                }
            }

            return null;
        }

        // Metodo verificador si hay un usuario con el mismo nombre en la base de datos
        public bool VerificadorUsuarioExistente(string nombreUsuario)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM USUARIOS WHERE NombreAlias = @usuario";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                    conn.Open();
                    int conteo = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    return conteo > 0;
                }
            }
        }



    }
}
