using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
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
        

        public int RegistrarNuevo(MateriaPrima nuevoMaterial)
        {
            int idGenerado = 0;
            using(var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO materiaprima (Nombre,Unidad,idProveedor,StockMinimo) VALUES (@nombre,@unidad,@proveedor,@minimo)";
                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre",nuevoMaterial.Nombre);
                    cmd.Parameters.AddWithValue("@unidad", nuevoMaterial.Unidad);
                    cmd.Parameters.AddWithValue("@proveedor", nuevoMaterial.Proveedor.idProveedor);
                    cmd.Parameters.AddWithValue("@minimo", nuevoMaterial.StockMinimo);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    idGenerado = (int)cmd.LastInsertedId;
                    conn.Close();

                    return idGenerado;
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

        public bool EntradaMateriaPrima(int idMateriaPrima, decimal cantidad, decimal costoUnitario, string referencia)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                int filasAfectadas;

                string query1 = "INSERT INTO movimientos_materiaprima (idMateriaPrima,cantidad,costoUnitario,tipoMovimiento,fechaMovimiento,referencia) VALUES" +
                    "(@id, @cantidad, @costo, 'Entrada', NOW(), @referencia)";

                string query2 = "UPDATE materiaprima SET Stock = IFNULL(Stock,0) + @cantidad WHERE idMateriaPrima = @id";

                using(var cmd = new MySqlCommand(query1, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMateriaPrima);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@costo", costoUnitario);
                    cmd.Parameters.AddWithValue("@referencia", referencia);
                    conn.Open();
                    filasAfectadas = cmd.ExecuteNonQuery();
                    conn.Close();
                }

                using(var cmd = new MySqlCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMateriaPrima);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    conn.Open();
                    filasAfectadas += cmd.ExecuteNonQuery();
                    conn.Close();
                }

                return filasAfectadas > 0;
            }
        }

        public List<movimiento_MateriaPrima> ConsultaRegistros()
        {
            var lista = new List<movimiento_MateriaPrima>();
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT r.idMovimiento,m.idMateriaPrima,m.Nombre AS Material,r.cantidad,r.costoUnitario,r.tipoMovimiento,r.fechaMovimiento,r.referencia " +
                    "FROM movimientos_materiaprima r " +
                    "INNER JOIN materiaprima m ON m.idMateriaPrima = r.idMovimiento;";

                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new movimiento_MateriaPrima
                            {
                                idMovimiento = reader.GetInt32("idMovimiento"),
                                MateriaPrima = new MateriaPrima
                                {
                                    idMateriaPrima = reader.GetInt32("idMateriaPrima"),
                                    Nombre = reader.GetString("Material")
                                },
                                Cantidad = reader.GetDecimal("cantidad"),
                                CostoUnitario = reader.GetDecimal("costoUnitario"),
                                TipoMovimiento = reader.GetString("tipoMovimiento"),
                                Fecha = reader.GetDateTime("fechaMovimiento"),
                                Referencia = reader.GetString("referencia")
                            });
                        }
                    }
                }
                conn.Close();
            }
            return lista;
        }


    }
}
