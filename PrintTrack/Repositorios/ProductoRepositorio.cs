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
    internal class ProductoRepositorio
    {
        public List<Productos> ObtenerProductos()
        {
            var list = new List<Productos>();

            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT a.idProducto, a.Nombre, a.PrecioVenta, a.StockActual,a.Estado, b.NombreCategoria, a.SKU, b.idCategoria " +
                    "FROM productos a INNER JOIN categoriaproductos b ON a.idCategoria = b.idCategoria;";

                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Productos
                            {
                                Nombre = reader.GetString("Nombre"),
                                PrecioVenta = reader.GetDecimal("PrecioVenta"),
                                StockActual = reader.GetDecimal("StockActual"),
                                Categoria = new CategoriaProductos
                                {
                                    idCategoria = reader.GetInt32("idCategoria"),
                                    NombreCategoria = reader.GetString("NombreCategoria")
                                },
                                SKU = reader.GetString("SKU"),
                                Estado = reader.GetInt32("Estado")
                            });
                        }
                        conn.Close();
                        return list;
                    }
                }
            }
        }

        public long RegistrarNuevoProducto(Productos nuevoProducto)
        {
            using(var conn = ConexionDB.ObtenerConexion()) 
            {
                string query = "INSERT INTO productos (Nombre, PrecioVenta, idCategoria, SKU, Estado, StockActual) VALUES " +
                    "(@nombre, @precioventa, @categoria, @sku, 1,0)";

                
                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nuevoProducto.Nombre);
                    cmd.Parameters.AddWithValue("@precioventa", nuevoProducto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@categoria", nuevoProducto.Categoria.idCategoria);
                    cmd.Parameters.AddWithValue("@sku", nuevoProducto.SKU);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    long idGenerado = cmd.LastInsertedId;

                    conn.Close();

                    return idGenerado;
                }

            }
        }
    }
}
