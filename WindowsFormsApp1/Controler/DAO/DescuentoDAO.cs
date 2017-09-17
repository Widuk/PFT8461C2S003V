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
    class DescuentoDAO
    {
        public List<DescuentoGridVO> getAllDescuentosGrid()
        {
            List<DescuentoGridVO> listaDescuentos = new List<DescuentoGridVO>();
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT descu.IDDESCUENTO, prod.NOMBRE, descu.DESCRIPCION, descu.ISPORCENTAJE, descu.PORCENTAJEDESCUENTO, descu.ISPRECIODIRECTO," +
                                  "descu.PRECIODESCUENTO, prod.SKU FROM descuento descu INNER JOIN producto prod ON descu.PRODUCTO_IDPRODUCTO = prod.IDPRODUCTO";
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DescuentoGridVO descGrid = new DescuentoGridVO();
                    descGrid.idDescuento = long.Parse(reader["IDDESCUENTO"].ToString());
                    descGrid.nombreProducto = reader["NOMBRE"].ToString();
                    descGrid.descripcionDescuento = reader["DESCRIPCION"].ToString();
                    descGrid.isPorcentajeDescuento = short.Parse(reader["ISPORCENTAJE"].ToString()) == 1 ? "SI" : "NO";
                    descGrid.porcentajeDescuento = double.Parse(reader["PORCENTAJEDESCUENTO"].ToString());
                    descGrid.isDescuentoDirecto = short.Parse(reader["ISPRECIODIRECTO"].ToString()) == 1 ? "SI" : "NO";
                    descGrid.precioDescuento = int.Parse(reader["PRECIODESCUENTO"].ToString());
                    descGrid.skuProducto = reader["SKU"].ToString();
                    listaDescuentos.Add(descGrid);
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return listaDescuentos;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void crearDescuento(Descuento desc)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_crea_descuento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = desc.nombre;
                cmd.Parameters.Add("DESCRIPCIONPARAM", OracleDbType.Varchar2).Value = desc.descripcion;
                cmd.Parameters.Add("ISPORCENTAJEPARAM", OracleDbType.Int16).Value = desc.isPorcentaje;
                cmd.Parameters.Add("PORCENTAJEDESCUENTO", OracleDbType.Decimal).Value = desc.porcentajeDescuento;
                cmd.Parameters.Add("ISPRECIODIRECTOPARAM", OracleDbType.Int16).Value = desc.isPrecioDirecto;
                cmd.Parameters.Add("PRECIODESCUENTOPARAM", OracleDbType.Int32).Value = desc.precioDescuento;
                cmd.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int32).Value = desc.idProducto;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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

        public Descuento obtenerDescuentoPorProducto(long idProducto)
        {
            OracleConnection conn = Conexion.Connect();
            Descuento desc = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Descuento WHERE PRODUCTO_IDPRODUCTO = :idProducto";
                cmd.Parameters.Add(":idProducto", OracleDbType.Int32).Value = idProducto;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    desc = new Descuento();
                    desc.idDescuento = long.Parse(reader["IDDESCUENTO"].ToString());
                    desc.nombre = reader["NOMBRE"].ToString();
                    desc.descripcion = reader["DESCRIPCION"].ToString();
                    desc.isPorcentaje = short.Parse(reader["ISPORCENTAJE"].ToString());
                    desc.porcentajeDescuento = double.Parse(reader["PORCENTAJEDESCUENTO"].ToString());
                    desc.isPrecioDirecto = short.Parse(reader["ISPRECIODIRECTO"].ToString());
                    desc.precioDescuento = int.Parse(reader["PRECIODESCUENTO"].ToString());
                    desc.idProducto = long.Parse(reader["PRODUCTO_IDPRODUCTO"].ToString());
                }

                reader.Close();
                cmd.Dispose();

                return desc;
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

        public void eliminarDescuentoPorId(long codigoDescuento)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_elimina_descuento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IDDESCUENTOPARAM", OracleDbType.Int32).Value = codigoDescuento;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch(Exception e)
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
