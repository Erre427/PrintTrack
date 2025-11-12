using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class ClientesRepositorio
    {
        // Obtener clientes de la base de datos
        public List<Clientes> ObtenerClientes()
        {
                var lista = new List<Clientes>();
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Cliente WHERE Estado = 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Clientes
                                {
                                    idCliente = reader.GetInt32("idCliente"),
                                    Nombre = reader.GetString("Nombre"),
                                    Telefono = reader.GetString("Telefono"),
                                    Email = reader.GetString("Email"),
                                    Descripcion = reader.GetString("Descripcion"),
                                    Estado = reader.GetInt32("Estado")
                                });
                            }
                        }
                    }
                conn.Close();
                }

                return lista;
        }

        public List<Clientes> ObtenerClientesArchivados()
        {
            var lista = new List<Clientes>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Cliente WHERE Estado = 0";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Clientes
                            {
                                idCliente = reader.GetInt32("idCliente"),
                                Nombre = reader.GetString("Nombre"),
                                Telefono = reader.GetString("Telefono"),
                                Email = reader.GetString("Email"),
                                Descripcion = reader.GetString("Descripcion"),
                                Estado = reader.GetInt32("Estado")
                            });
                        }
                    }
                }
                conn.Close();
            }

            return lista;
        }


        // Agregar clientes a la base de datos
        public bool AgregarCliente(Clientes cliente)
        {
            using(var conexion = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO CLIENTE (Nombre,Telefono,Descripcion,Email) VALUES (@Nombre,@Telefono,@Descripcion,@Email)";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Descripcion", cliente.Descripcion);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);

                    conexion.Open();
                    int filasafectadas = cmd.ExecuteNonQuery();
                    conexion.Close();
                    return filasafectadas > 0;
                }
            }
        }

        // Archivar cliente, actualiza el campo ESTADO
        public bool ArchivarCliente(int idCliente)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE Cliente SET Estado = 0 WHERE (idCliente = @id)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id",idCliente);

                    conn.Open();
                    int filasafectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasafectadas > 0;
                }
            }
        }

        public bool DesarchivarCliente(int idCliente)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE Cliente SET Estado = 1 WHERE (idCliente = @id)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    conn.Open();
                    int filasafectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasafectadas > 0;
                }
            }
        }

        public bool EditarCliente(Clientes cliente)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE Cliente SET Nombre = @nombre, Telefono = @telefono, Descripcion = @descripcion, Email = @email WHERE (idCliente = @id)";
                using (var cmd = new MySqlCommand (query, conn))
                {
                    cmd.Parameters.AddWithValue("@id",cliente.idCliente);
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@descripcion", cliente.Descripcion);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);

                    conn.Open();
                    int filasafectadas = cmd.ExecuteNonQuery();
                    conn.Close();
                    return filasafectadas > 0;

                }
            }
        }


    }
}
