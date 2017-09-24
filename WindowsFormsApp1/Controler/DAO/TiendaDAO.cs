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
    class TiendaDAO
    {
        public List<Tienda> listarTiendas()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM TIENDA";
                OracleDataReader dr = command.ExecuteReader();

                List<Tienda> lstTienda = new List<Tienda>();

                while (dr.Read())
                {
                    Tienda entTienda = new Tienda();
                    entTienda.idTienda = int.Parse(dr["IDTIENDA"].ToString());
                    entTienda.nombre = (string)dr["NOMBRE"];
                    entTienda.direccion = (string)dr["DIRECCION"];
                    entTienda.ciudad_idCiudad = int.Parse(dr["CIUDAD_IDCIUDAD"].ToString());
                    entTienda.telefono = (string)(dr["TELEFONO"]);
                    entTienda.isActivo = sbyte.Parse(dr["ISACTIVO"].ToString());
                    entTienda.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    entTienda.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    entTienda.empresa = (String)(dr["EMPRESA"].ToString());

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
        public void EditarTienda(Int16 idTienda, String nombre, String direccion, String telefono, DateTime fechamodificacion, String empresa, Int16 ciudad_idciudad)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_modifica_tienda";
                command.Parameters.Add("IDTIENDAPARAM", OracleDbType.Int16).Value = idTienda;
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
