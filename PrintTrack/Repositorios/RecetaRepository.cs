using MySql.Data.MySqlClient;
using PrintTrack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTrack.Repositorios
{
    internal class RecetaRepository
    {
        public void RegistrarReceta(Receta nuevaReceta)
        {
            using (var conn = ConexionDB.ObtenerConexion())
            {
                string query = "INSERT INTO receta (Productos, MateriaPrima, CantidadNeta, NotaAdicional) VALUES " +
                    "(@producto, @material, @cantidad, @nota)";

                using(var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@producto", nuevaReceta.idProducto.idProducto);
                    cmd.Parameters.AddWithValue("@material", nuevaReceta.idMateriaPrima.idMateriaPrima);
                    cmd.Parameters.AddWithValue("@cantidad", nuevaReceta.CantidadNeta);
                    cmd.Parameters.AddWithValue("@nota", nuevaReceta.NotaAdicional);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
