using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class MateriaPrimaRepositorio
    {
        public List<MateriaPrima> ObtenerLista()
        {
            var lista = new List<MateriaPrima>();
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT m.idMateriaPrima,m.Nombre, m.Unidad, m.Stock, m.StockMinimo, p.NombreProveedor, p.idProveedor  " +
                    "FROM materiaprima m " +
                    "INNER JOIN proveedores p ON m.idProveedor = p.idProveedor";
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new MateriaPrima
                            {
                                idMateriaPrima = reader.GetInt32("idMateriaPrima"),
                                Nombre = reader.GetString("Nombre"),
                                Unidad = reader.GetString("Unidad"),
                                Stock = reader.GetDecimal("Stock"),
                                Proveedor = new Proveedores
                                {
                                    idProveedor = reader.GetInt32("idProveedor"),
                                    Nombre = reader.GetString("NombreProveedor")
                                },
                                StockMinimo = reader.GetDecimal("StockMinimo")
                            });
                        }
                    }
                }
                conn.Close();
            }
            return lista;
        }
        

        public bool RegistrarNuevo(MateriaPrima nuevoMaterial)
        {
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO materiaprima (Nombre,Unidad,Stock,idProveedor,StockMinimo) VALUES (@nombre,@unidad,@stock,@proveedor,@minimo)";
                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre",nuevoMaterial.Nombre);
                    cmd.Parameters.AddWithValue("@unidad", nuevoMaterial.Unidad);
                    cmd.Parameters.AddWithValue("@stock", nuevoMaterial.Stock);
                    cmd.Parameters.AddWithValue("@proveedor", nuevoMaterial.Proveedor.idProveedor);
                    cmd.Parameters.AddWithValue("@minimo", nuevoMaterial.StockMinimo);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }
            }
        }

        public bool EditarMaterial(MateriaPrima materialEditado)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "UPDATE materiaprima SET Nombre = @nombre, idProveedor = @proveedor WHERE idMateriaPrima = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", materialEditado.idMateriaPrima);
                    cmd.Parameters.AddWithValue("@nombre", materialEditado.Nombre);
                    cmd.Parameters.AddWithValue("@proveedor", materialEditado.Proveedor.idProveedor);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();

                    return filasAfectadas > 0;
                }

            }
        }



    }
}
