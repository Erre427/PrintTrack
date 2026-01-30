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
    internal class ProveedorRepositorio
    {
        public List<Proveedores> ObtenerProveedores()
        {
            var lista = new List<Proveedores>();
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT * FROM Proveedores";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proveedores
                            {
                                idProveedor = reader.GetInt32("idProveedor"),
                                Nombre = reader.GetString("NombreProveedor"),
                                Telefono = reader.GetString("Telefono"),
                                Direccion = reader.GetString("Direccion"),
                                Correo = reader.GetString("Correo")
                            });
                        }
                        conn.Close();
                    }
                }
                
            }
            return lista;
        }


        public List<Proveedores> ObtenerIDs()
        {
            var lista = new List<Proveedores>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT idProveedor, NombreProveedor FROM proveedores";

                conn.Open();
                using(var cmd = new MySqlCommand(query, conn))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proveedores
                            {
                                idProveedor = reader.GetInt32("idProveedor"),
                                Nombre = reader.GetString("NombreProveedor")
                            });
                        }
                    }
                    conn.Close();
                }
                return lista;
            }
        }

        public bool RegistrarNuevo(Proveedores nuevoProveedor)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO Proveedores (NombreProveedor,Telefono,Direccion,Correo) VALUES (@nombre,@telefono,@direccion,@correo)";
                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nuevoProveedor.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", nuevoProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", nuevoProveedor.Direccion);
                    cmd.Parameters.AddWithValue("@correo", nuevoProveedor.Correo);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }
            }
        }





    }

    

}

