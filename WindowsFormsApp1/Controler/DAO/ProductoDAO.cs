using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1.Controler.DAO
{
    class ProductoDAO
    {
        public DataTable getProductosCbx()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT idProducto, nombre FROM producto WHERE isActivo = 1";
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable("Productos");
                oda.Fill(dataTable);

                return dataTable;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        
        public Producto getProductoPorID(long idProducto)
        {
            OracleConnection conn = Conexion.Connect();
            Producto prod = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Producto WHERE IDPRODUCTO = :idProducto";
                cmd.Parameters.Add(":idProducto", OracleDbType.Int32).Value = idProducto;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    prod = new Producto();
                    prod.idProducto = long.Parse(reader["IDPRODUCTO"].ToString());
                    prod.nombreProducto = reader["NOMBRE"].ToString();
                    prod.descripcionProducto = reader["DESCRIPCION"].ToString();
                    prod.precio = int.Parse(reader["PRECIO"].ToString());
                    prod.isDosPorUno = short.Parse(reader["ISDOSPORUNO"].ToString());
                    prod.SKU = reader["SKU"].ToString();
                    prod.isActivo = short.Parse(reader["ISACTIVO"].ToString());
                    prod.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    prod.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    prod.idTienda = long.Parse(reader["TIENDA_IDTIENDA"].ToString());
                    prod.idRubro = long.Parse(reader["RUBRO_IDRUBRO"].ToString());
                }

                reader.Close();
                cmd.Dispose();

                return prod;
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

        public List<Producto> listarProducto()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM PRODUCTO where isactivo = 1";
                OracleDataReader dr = command.ExecuteReader();

                List<Producto> lstPrducto = new List<Producto>();

                while (dr.Read())
                {
                    Producto entProducto = new Producto();
                    entProducto.idProducto = int.Parse(dr["IDPRODUCTO"].ToString());
                    entProducto.nombreProducto = (string)dr["NOMBRE"];
                    entProducto.descripcionProducto = (string)dr["DESCRIPCION"];
                    entProducto.idRubro = int.Parse(dr["RUBRO_IDRUBRO"].ToString());
                    entProducto.SKU = (string)dr["SKU"];
                    entProducto.precio = int.Parse(dr["PRECIO"].ToString());
                    entProducto.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    entProducto.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    entProducto.isActivo = sbyte.Parse(dr["ISACTIVO"].ToString());
                    entProducto.idTienda = int.Parse(dr["TIENDA_IDTIENDA"].ToString());
                    entProducto.isDosPorUno = sbyte.Parse(dr["ISDOSPORUNO"].ToString());
                    lstPrducto.Add(entProducto);
                }
                dr.Close();
                command.Dispose();
                return lstPrducto;
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

        public void EliminarProducto(Int16 IDPRODUCTO)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_elimina_producto";
                command.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int16).Value = IDPRODUCTO;
                OracleDataReader dr = command.ExecuteReader();
                dr.Close();
                command.Dispose();
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

        public void InsertaProducto(String nombre, String DESCRIPCION, String PRECIO, String ISDOSPORUNO, String SKU, int ISACTIVO, DateTime FECHACREACION, DateTime FECHAMODIFICACION, Int16 TIENDA_IDTIENDA, Int16 RUBRO_IDRUBRO)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_CREA_PRODUCTO";
                command.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = nombre;
                command.Parameters.Add("DESCRIPCIONPARAM", OracleDbType.Varchar2).Value = DESCRIPCION;
                command.Parameters.Add("PRECIOPARAM", OracleDbType.Varchar2).Value = PRECIO;
                command.Parameters.Add("ISDOSPORUNOPARAM", OracleDbType.Int16).Value = ISDOSPORUNO;
                command.Parameters.Add("SKUPARAM", OracleDbType.Varchar2).Value = SKU;
                command.Parameters.Add("ISACTIVOPARAM", OracleDbType.Int16).Value = ISACTIVO;
                command.Parameters.Add("FECHACREACIONPARAM", OracleDbType.TimeStamp).Value = FECHACREACION;
                command.Parameters.Add("FECHAMODIFICACIONPARAM", OracleDbType.TimeStamp).Value = FECHAMODIFICACION;
                command.Parameters.Add("TIENDA_IDTIENDAPARAM", OracleDbType.Int16).Value = TIENDA_IDTIENDA;
                command.Parameters.Add("RUBRO_IDRUBROPARAM", OracleDbType.Int16).Value = RUBRO_IDRUBRO;
                OracleDataReader dr = command.ExecuteReader();
                dr.Close();
                command.Dispose();
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

        public void EditarProducto(Int16 idProducto, String nombre, String DESCRIPCION, String PRECIO, Int16 ISDOSPORUNO, String SKU, Int16 ISACTIVO, DateTime FECHAMODIFICACION, Int16 TIENDA_IDTIENDA, Int16 RUBRO_IDRUBRO)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_modifica_producto";
                command.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int16).Value = idProducto;
                command.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = nombre;
                command.Parameters.Add("DESCRIPCIONPARAM", OracleDbType.Varchar2).Value = DESCRIPCION;
                command.Parameters.Add("PRECIOPARAM", OracleDbType.Varchar2).Value = PRECIO;
                command.Parameters.Add("ISDOSPORUNOPARAM", OracleDbType.Int16).Value = ISDOSPORUNO;
                command.Parameters.Add("SKUPARAM", OracleDbType.Varchar2).Value = SKU;
                command.Parameters.Add("ISACTIVOPARAM", OracleDbType.Int16).Value = ISACTIVO;
                command.Parameters.Add("FECHAMODIFICACIONPARAM", OracleDbType.TimeStamp).Value = FECHAMODIFICACION;
                command.Parameters.Add("TIENDA_IDTIENDAPARAM", OracleDbType.Int16).Value = TIENDA_IDTIENDA;
                command.Parameters.Add("RUBRO_IDRUBROPARAM", OracleDbType.Int16).Value = RUBRO_IDRUBRO;
                OracleDataReader dr = command.ExecuteReader();
                dr.Close();
                command.Dispose();
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
