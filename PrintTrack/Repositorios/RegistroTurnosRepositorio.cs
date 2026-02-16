using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using PrintTrack.Forms.F_Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class RegistroTurnosRepositorio
    {
        public List<registroTurnos> ObtenerRegistros()
        {
            var lista = new List<registroTurnos>();
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT r.idRegistro, u.idUsuarios, u.NombreCompleto, r.Estado, r.FechaInicio, r.FechaFin, r.TotalHoras " +
                    "FROM usuarios u INNER JOIN registroturnos r ON r.idUsuarios = u.idUsuarios";

                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new registroTurnos()
                            {
                                idRegistro = Convert.ToInt32(reader["idRegistro"]),
                                Usuario = new Usuarios
                                {
                                    idUsuarios = Convert.ToInt32(reader["idUsuarios"]),
                                    NombreCompleto = reader["NombreCompleto"].ToString()
                                },
                                Estado = Convert.ToInt32(reader["Estado"]),
                                FechaInicio = reader["FechaInicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = reader["FechaFin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaFin"]),
                                TotalHoras = reader["TotalHoras"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TotalHoras"])
                            });
                        }
                        conn.Close();
                    }
                }
            }
            return lista;
        }

        public bool RegistrarTurno(int idUsuario, int estado)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO registroturnos (idUsuarios, Estado, FechaInicio) VALUES (@id, @estado, @hora)";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@hora", DateTime.Now);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }
            }

        }

        public bool FinalizarTurno(int idRegistro)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = @"UPDATE registroturnos 
                         SET FechaFin = @fecha, 
                             Estado = 0,
                             TotalHoras = TIMESTAMPDIFF(HOUR, FechaInicio, @fecha)
                         WHERE idRegistro = @id";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", idRegistro);

                    conn.Open();
                    int exito = cmd.ExecuteNonQuery();
                    conn.Close();

                    return exito > 0;
                }
            }

        }

        public int ConsultaRegistro(int idUsuario)
        {
            int idEncontrado = 0;
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT idRegistro, FechaInicio, Estado FROM registroturnos " +
                    "WHERE idUsuarios = @id AND FechaFin IS NULL";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idUsuario);

                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    if(resultado != null)
                    {
                        idEncontrado = Convert.ToInt32(resultado);
                    }
                    conn.Close();
                }
            }

            return idEncontrado;
        }


        public int ObtenerEstadoTurno(int idRegistro)
        {
            int Estado = 0;
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT Estado FROM registroturnos WHERE idRegistro = @id";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idRegistro);

                    conn.Open();
                    object resultado = cmd.ExecuteScalar();
                    conn.Close();

                    if(resultado != null)
                    {
                        Estado = Convert.ToInt32(resultado);
                    }

                    return Estado;
                }
            }
        }
    }
}
