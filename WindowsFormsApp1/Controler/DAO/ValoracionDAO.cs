using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Controler.DAO
{
    class ValoracionDAO
    {
        public List<ReporteValoracionVO> getValoracionesTienda(long codigoTienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT " +
                                      "valor.nota," +
                                      "valor.detalle," +
                                      "valor.fechacreacion," +
                                      "ofer.idoferta," +
                                      "ofer.fechainicio," +
                                      "ofer.fechafin," +
                                      "prod.idproducto," +
                                      "prod.nombre," +
                                      "prod.precio," +
                                      "cons.rut," +
                                      "cons.dv," +
                                      "cons.nombre AS nombre_consumidor," +
                                      "cons.apellidopaterno," +
                                      "cons.apellidomaterno " +
                                      "FROM " +
                                      "valoracion valor " +
                                      "INNER JOIN oferta ofer ON valor.oferta_idoferta = ofer.idoferta " +
                                      "INNER JOIN rl_oferta_tienda rlofertien ON rlofertien.oferta_idoferta = ofer.idoferta " +
                                      "INNER JOIN usuario usu ON usu.idusuario = valor.usuario_idusuario " +
                                      "INNER JOIN producto prod ON ofer.producto_idproducto = prod.idproducto " +
                                      "INNER JOIN consumidor cons ON cons.usuario_idusuario = usu.idusuario " +
                                      "WHERE " +
                                      "rlofertien.tienda_idtienda = :codigoTienda";
                command.Parameters.Add(":codigoTienda", OracleDbType.Int32).Value = codigoTienda;
                OracleDataReader dr = command.ExecuteReader();

                List<ReporteValoracionVO> listaReporte = new List<ReporteValoracionVO>();

                while (dr.Read())
                {
                    ReporteValoracionVO reporte = new ReporteValoracionVO();
                    reporte.notaValoracion = int.Parse(dr["NOTA"].ToString());
                    reporte.detalleValoracion = dr["DETALLE"].ToString();
                    reporte.fechaValoracion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    reporte.codigoOferta = long.Parse(dr["IDOFERTA"].ToString());
                    reporte.fechaInicioOferta = DateTime.Parse(dr["FECHAINICIO"].ToString());
                    reporte.fechaTerminoOferta = DateTime.Parse(dr["FECHAFIN"].ToString());
                    reporte.codigoProducto = long.Parse(dr["IDPRODUCTO"].ToString());
                    reporte.nombreProducto = dr["NOMBRE"].ToString();
                    reporte.precioProducto = int.Parse(dr["PRECIO"].ToString());
                    reporte.rutConsumidor = dr["RUT"].ToString() + "-" + dr["dv"].ToString();
                    reporte.nombreConsumidor = dr["NOMBRE_CONSUMIDOR"].ToString() + " " + dr["APELLIDOPATERNO"].ToString() + " " + dr["APELLIDOMATERNO"].ToString();
                    listaReporte.Add(reporte);
                }

                command.Dispose();
                dr.Close();
                dr.Dispose();

                return listaReporte;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
