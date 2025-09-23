using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
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
        public List<Clientes> ObtenerClientes()
        {
                var lista = new List<Clientes>();
                using (var conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Cliente";
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
                                    Descripcion = reader.GetString("Descripcion")
                                });
                            }
                        }
                    }
                }

                return lista;
        }
    }
}
