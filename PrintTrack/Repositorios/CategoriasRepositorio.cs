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
        public List<CategoriaProductos> GetCategorias()
        {
            var listaCategorias = new List<CategoriaProductos>();
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT idCategoria, NombreCategoria FROM categoriaproductos";
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
    }
}
