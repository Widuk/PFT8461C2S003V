using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Controler.DAO
{
    class ReporteDAO
    {
        public ReporteTiendaVO listarReporte(String _idtienda)
        {
            ReporteTiendaVO entReporteTienda = new ReporteTiendaVO();
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select Tt.Nombre,Sum((select count(*) from usuario u inner join valoracion v on v.usuario_idusuario = u.idusuario inner join oferta o on o.idoferta = v.oferta_idoferta inner join rl_oferta_tienda ot on Ot.Oferta_Idoferta = o.idoferta where tienda_idtienda = tt.idtienda)) as cantUsuarios ,Sum((select count(*) from Logemail lm2 inner join oferta o2 on o2.idoferta = lm2.oferta_idoferta inner join rl_oferta_tienda ot2 on ot2.oferta_idoferta = o2.idoferta where ot2.tienda_idtienda = tt.idtienda)) as cantMail ,Sum((select count(*) from valoracion v inner join oferta o on o.idoferta = v.oferta_idoferta inner join rl_oferta_tienda ot on Ot.Oferta_Idoferta = o.idoferta where tienda_idtienda = tt.idtienda)) as cantValoracion from tienda tt where idtienda = "+_idtienda+" group by Tt.Nombre";
                OracleDataReader dr = command.ExecuteReader();

                //List<ReporteTiendaVO> lstTienda = new List<ReporteTiendaVO>();

                while (dr.Read())
                {
                    ReporteTiendaVO entTienda = new ReporteTiendaVO();
                    //entTienda.idTienda = int.Parse(dr["IDTIENDA"].ToString());
                    entReporteTienda.nombreTienda = (string)dr["NOMBRE"];
                    entReporteTienda.cantUsuarios = (string)dr["cantUsuarios"].ToString();
                    entReporteTienda.cantMail = (string)dr["cantMail"].ToString();
                    entReporteTienda.cantValoracion = (string)dr["cantValoracion"].ToString();
                    //lstTienda.Add(entTienda);
                }

                dr.Close();
                command.Dispose();
                return entReporteTienda;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public List<ReporteTiendaVO> listarRubro(String _idtienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select r.Nombre ,Sum((select count(*) from descuento d2 inner join producto p2 on p2.idproducto = D2.Producto_Idproducto inner join rl_prod_tienda pt2 on pt2.producto_idproducto = p2.idproducto where pt2.tienda_idtienda = pt.tienda_idtienda)) as cantDescuentos from rubro r inner join producto p on p.rubro_idrubro = R.Idrubro inner join rl_prod_tienda pt on pt.producto_idproducto = p.idproducto where tienda_idtienda = "+_idtienda+" group by r.Nombre";
                OracleDataReader dr = command.ExecuteReader();

                List<ReporteTiendaVO> lstTienda = new List<ReporteTiendaVO>();

                while (dr.Read())
                {
                    ReporteTiendaVO entTienda = new ReporteTiendaVO();
                    entTienda.nombreRubro = (string)dr["NOMBRE"].ToString();
                    entTienda.cantidadDescuentos = (string)dr["cantDescuentos"].ToString();
                    lstTienda.Add(entTienda);
                }

                dr.Close();
                command.Dispose();
                return lstTienda;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
