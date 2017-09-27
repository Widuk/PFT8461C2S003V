﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.Model.Negocio.Vo;
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
                cmd.CommandText = "SELECT idProducto, nombre FROM producto WHERE isActivo = 1 order by nombre";
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
                cmd.CommandText = "SELECT * FROM Producto WHERE IDPRODUCTO = :idProducto order by nombre";
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

        public List<ProductoGridVO> listarProducto()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT p.IDPRODUCTO,p.NOMBRE,p.DESCRIPCION,p.PRECIO,p.ISDOSPORUNO,p.SKU,p.ISACTIVO,p.FECHACREACION,p.FECHAMODIFICACION,p.TIENDA_IDTIENDA,p.RUBRO_IDRUBRO,t.NOMBRE AS NOMBRETIENDA,r.NOMBRE AS NOMBRERUBRO FROM PRODUCTO p inner join tienda t on t.idtienda = p.tienda_idtienda inner join rubro r on r.idrubro = P.Rubro_Idrubro where p.isactivo = 1 order by p.nombre";
                OracleDataReader dr = command.ExecuteReader();
                List<ProductoGridVO> lstPrducto = new List<ProductoGridVO>();
                while (dr.Read())
                {
                    ProductoGridVO entProducto = new ProductoGridVO();
                    entProducto.idProducto = long.Parse(dr["IDPRODUCTO"].ToString());
                    entProducto.nombreProducto = (string)dr["NOMBRE"];
                    entProducto.descripcionProducto = (string)dr["DESCRIPCION"];
                    entProducto.nombreRubro = (string)dr["NOMBRERUBRO"];
                    entProducto.SKU = (string)dr["SKU"];
                    entProducto.precio = int.Parse(dr["PRECIO"].ToString());
                    entProducto.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    entProducto.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    entProducto.isActivo = sbyte.Parse(dr["ISACTIVO"].ToString());
                    entProducto.nombreTienda = (string)dr["NOMBREtienda"];
                    entProducto.DosPorUno = (String)dr["ISDOSPORUNO"].ToString().Replace("1","Si").Replace("0","No");
                    entProducto.isDosPorUno = sbyte.Parse(dr["ISDOSPORUNO"].ToString());
                    entProducto.idTienda = long.Parse(dr["TIENDA_IDTIENDA"].ToString());
                    entProducto.idRubro = long.Parse(dr["RUBRO_IDRUBRO"].ToString());
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

        public void EditarProducto(Int64 idProducto, String nombre, String DESCRIPCION, Int64 PRECIO, Int16 ISDOSPORUNO, String SKU, Int16 ISACTIVO, DateTime FECHAMODIFICACION, Int16 TIENDA_IDTIENDA, Int16 RUBRO_IDRUBRO)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_modifica_producto";
                command.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int64).Value = idProducto;
                command.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = nombre;
                command.Parameters.Add("DESCRIPCIONPARAM", OracleDbType.Varchar2).Value = DESCRIPCION;
                command.Parameters.Add("PRECIOPARAM", OracleDbType.Int64).Value = PRECIO;
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