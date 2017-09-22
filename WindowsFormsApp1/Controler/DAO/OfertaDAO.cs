using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1.Controler.DAO
{
    class OfertaDAO
    {
        public Oferta getOfertaVigenteByCodigoProducto(long codigoProducto)
        {
            OracleConnection conn = Conexion.Connect();
            Oferta oferta = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Oferta WHERE PRODUCTO_IDPRODUCTO = :codigoProducto AND FECHAFIN > :fechaActualFin AND FECHAINICIO < :fechaActualInicio";
                cmd.Parameters.Add(":codigoProducto", OracleDbType.Int32).Value = codigoProducto;
                cmd.Parameters.Add(":fechaActualFin", OracleDbType.Date).Value = new DateTime();
                cmd.Parameters.Add(":fechaActualInicio", OracleDbType.Date).Value = new DateTime();
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oferta = new Oferta();
                    oferta.idOferta = long.Parse(reader["IDOFERTA"].ToString());
                    oferta.fechaInicio = DateTime.Parse(reader["FECHAINICIO"].ToString());
                    oferta.fechaFin = DateTime.Parse(reader["FECHAFIN"].ToString());
                    oferta.rutaFoto = reader["RUTAFOTO"].ToString();
                    oferta.minimoProductos = int.Parse(reader["MINIMOPRODUCTOS"].ToString());
                    oferta.maximoProductos = int.Parse(reader["MAXIMOPRODUCTOS"].ToString());
                    oferta.isPublicada = short.Parse(reader["ISPUBLICADA"].ToString());
                    oferta.idProducto = long.Parse(reader["PRODUCTO_IDPRODUCTO"].ToString());
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return oferta;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }     
    }
}
