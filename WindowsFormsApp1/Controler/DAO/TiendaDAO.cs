﻿using Oracle.ManagedDataAccess.Client;
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
    class TiendaDAO
    {
        public List<TiendaGridVO> listarTiendas()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT t.IDTIENDA,t.NOMBRE,t.DIRECCION,t.TELEFONO,t.ISACTIVO,t.FECHACREACION,t.FECHAMODIFICACION,t.EMPRESA,t.ciudad_idciudad as idciudad,c.NOMBRE AS NOMBRECIUDAD FROM TIENDA t inner join ciudad c on c.idciudad = t.ciudad_idciudad where t.isactivo = 1 order by t.nombre";
                OracleDataReader dr = command.ExecuteReader();

                List<TiendaGridVO> lstTienda = new List<TiendaGridVO>();

                while (dr.Read())
                {
                    TiendaGridVO entTienda = new TiendaGridVO();
                    entTienda.idTienda = int.Parse(dr["IDTIENDA"].ToString());
                    entTienda.nombreTienda = (string)dr["NOMBRE"];
                    entTienda.direccion = (string)dr["DIRECCION"];                    
                    entTienda.telefono = (string)(dr["TELEFONO"]);
                    entTienda.isActivo = sbyte.Parse(dr["ISACTIVO"].ToString());
                    entTienda.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    entTienda.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    entTienda.empresa = (String)(dr["EMPRESA"].ToString());
                    entTienda.idCiudad = int.Parse(dr["IDCIUDAD"].ToString());
                    entTienda.nombreCiudad = (string)dr["NOMBRECIUDAD"];
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


        public Usuario buscaTiendaPorNombre(String nombreTienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM TIENDA WHERE NOMBRE = :nombreTienda";
                //command.Parameters.Add(":nombreTienda", OracleDbType.Int32).Value = codigoUsuario;
                OracleDataReader dr = command.ExecuteReader();

                Usuario usu = null;

                while (dr.Read())
                {
                    usu = new Usuario();
                    usu.idUsuario = long.Parse(dr["IDUSUARIO"].ToString());
                    usu.login = (string)dr["LOGIN"];
                    usu.password = (string)dr["PASSWORD"];
                    usu.isActivo = short.Parse(dr["ISACTIVO"].ToString());
                    usu.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    usu.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    usu.idSession = !dr.IsDBNull(6) ? (string)dr["IDSESSION"] : "";
                    usu.codigoPerfil = long.Parse(dr["PERFIL_IDPERFIL"].ToString());
                }

                dr.Close();
                command.Dispose();
                return usu;
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

        public void InsertaTienda(String nombre, String direccion, String telefono, sbyte isactivo, DateTime fechacreacion, DateTime fechamodificacion, String empresa, Int16 ciudad_idciudad)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_CREA_TIENDA";
                command.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = nombre;
                command.Parameters.Add("DIRECCIONPARAM", OracleDbType.Varchar2).Value = direccion;
                command.Parameters.Add("TELEFONOPARAM", OracleDbType.Varchar2).Value = telefono;
                command.Parameters.Add("ISACTIVOPARAM", OracleDbType.Int16).Value = isactivo;
                command.Parameters.Add("FECHACREACIONPARAM", OracleDbType.TimeStamp).Value = fechacreacion;
                command.Parameters.Add("FECHAMODIFICACIONPARAM", OracleDbType.TimeStamp).Value = fechamodificacion;
                command.Parameters.Add("EMPRESAPARAM", OracleDbType.Varchar2).Value = empresa;
                command.Parameters.Add("CIUDAD_IDCIUDADPARAM", OracleDbType.Int16).Value = ciudad_idciudad;
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

        public void EliminarTienda(Int16 IDTIENDA)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_elimina_tienda";
                command.Parameters.Add("IDTIENDAPARAM", OracleDbType.Int16).Value = IDTIENDA;
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
        public void EditarTienda(long idTienda, String nombre, String direccion, String telefono, DateTime fechamodificacion, String empresa, Int16 ciudad_idciudad)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_modifica_tienda";
                command.Parameters.Add("IDTIENDAPARAM", OracleDbType.Long).Value = idTienda;
                command.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = nombre;
                command.Parameters.Add("DIRECCIONPARAM", OracleDbType.Varchar2).Value = direccion;
                command.Parameters.Add("TELEFONOPARAM", OracleDbType.Varchar2).Value = telefono;
                command.Parameters.Add("FECHAMODIFICACIONPARAM", OracleDbType.TimeStamp).Value = fechamodificacion;
                command.Parameters.Add("EMPRESAPARAM", OracleDbType.Varchar2).Value = empresa;
                command.Parameters.Add("CIUDAD_IDCIUDADPARAM", OracleDbType.Int16).Value = ciudad_idciudad;
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