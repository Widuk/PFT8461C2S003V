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
    }
}
