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
                string query = "SELECT m.Nombre, m.Unidad, m.Stock, m.StockMinimo, p.Nombre " +
                    "FROM materiaprima m " +
                    "INNER JOIN proveedores p ON m.idProveedor = p.idProveedor";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        conn.Open();
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
                                    Nombre = reader.GetString("Nombre")
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
        



    }
}
