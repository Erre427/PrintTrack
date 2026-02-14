using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class CategoriasRepositorio
    {
        public List<CategoriaProductos> GetCategorias(bool flag)
        {
            var listaCategorias = new List<CategoriaProductos>();
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT idCategoria, NombreCategoria FROM categoriaproductos";

                if (flag == false)
                    query += " WHERE idCategoria != 0";

                conn.Open();
                using(var cmd = new MySqlCommand(query, conn))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCategorias.Add(new CategoriaProductos
                            {
                                idCategoria = Convert.ToInt32(reader["idCategoria"]),
                                NombreCategoria = reader["NombreCategoria"].ToString()
                            });
                        }
                    }
                    conn.Close();
                }
                return listaCategorias;
            }
        }

        public bool AgregarCategoria(string nombreCategoria)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO categoriaproductos (NombreCategoria) VALUES (@nombre)";
                conn.Open();
                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreCategoria);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
