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
        
        public Tienda buscaTiendaPorNombre(String nombreTienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT NOMBRE FROM TIENDA WHERE isactivo = 1 and NOMBRE = '"+nombreTienda + "'";
                OracleDataReader dr = command.ExecuteReader();
                Tienda tien = null;
                while (dr.Read())
                {
                    tien = new Tienda();
                    tien.nombre = (string)dr["NOMBRE"];
                }

                dr.Close();
                command.Dispose();
                return tien;
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

        public DataTable ListarTiendaDT()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command= conn.CreateCommand();
                DataTable dataTable = new DataTable("TIENDA");
                command.CommandText = "SELECT IDTIENDA,NOMBRE FROM TIENDA where isactivo = 1 order by nombre";
                OracleDataAdapter oda = new OracleDataAdapter(command);
                dataTable.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("IDTIENDA", typeof(int)),
                        new DataColumn("NOMBRE", typeof(string)),
                    });
                oda.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public int buscaIdTiendaPorNombre2(String nombreTienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                int id = 0;
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT IDTIENDA FROM TIENDA WHERE isactivo = 1 and NOMBRE = '" + nombreTienda + "'";
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    id= int.Parse(dr["IDTIENDA"].ToString());
                }                

                dr.Close();
                command.Dispose();
                return id;
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
        public Boolean buscaTiendaNoAsociada(int idTienda)
        {
            Boolean activo = false;
            OracleConnection conn = Conexion.Connect();
            try
            {
                String skuproducto = String.Empty;
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "select p.idproducto from producto p inner join Rl_Prod_Tienda r on R.Producto_Idproducto = P.Idproducto inner join tienda t on T.Idtienda = R.Tienda_Idtienda where P.Isactivo = 1 and T.Idtienda ="+idTienda;
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    activo = true;
                }

                dr.Close();
                command.Dispose();
                return activo;
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

        public DataTable getTiendasCbx()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT IDTIENDA, NOMBRE FROM TIENDA WHERE ISACTIVO = 1";
                OracleDataAdapter oda = new OracleDataAdapter(comm);
                DataTable dataTable = new DataTable("Tiendas");
                oda.Fill(dataTable);

                return dataTable;
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
        public List<TiendaGridVO> lt()
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

        public LinkedList< String> obtenerReportePorTienda(String tienda)
        {
            OracleConnection conn = Conexion.Connect();
            StringBuilder queryTienda = new StringBuilder();
            StringBuilder queryUsuarios = new StringBuilder();
            StringBuilder queryOfertasEnviadas = new StringBuilder();
            StringBuilder queryValoraciones = new StringBuilder();
            StringBuilder queryDescuentosPorRubro = new StringBuilder();
            try
            {
                OracleCommand command = conn.CreateCommand();

                queryTienda.Append("SELECT COUNT(*) FROM tienda t WHERE t.nombre LIKE ");
                queryTienda.Append(tienda);

                command.CommandText = queryTienda.ToString();

                OracleDataReader dr = command.ExecuteReader();

                List<TiendaGridVO> lstTienda = new List<TiendaGridVO>();
                int count = 0;
                while (dr.Read())
                {
                    count = Int32.Parse(dr["count"].ToString());
                    count = Convert.ToInt32(dr["count"]);
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

                return new LinkedList<String>();
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