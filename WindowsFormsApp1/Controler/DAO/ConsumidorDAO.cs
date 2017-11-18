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
    class ConsumidorDAO
    {
        public Consumidor getConsumidorPorCodigoUsuario(long codigoUsuario)
        {
            OracleConnection conn = Conexion.Connect();
            Consumidor cons = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Consumidor WHERE USUARIO_IDUSUARIO = :idUsuario";
                cmd.Parameters.Add(":idUsuario", OracleDbType.Int32).Value = codigoUsuario;

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cons = new Consumidor();
                    cons.idConsumidor = long.Parse(reader["IDCONSUMIDOR"].ToString());
                    cons.rut = int.Parse(reader["RUT"].ToString());
                    cons.dv = reader["DV"].ToString();
                    cons.nombre = reader["NOMBRE"].ToString();
                    cons.apellidoPaterno = reader["APELLIDOPATERNO"].ToString();
                    cons.apellidoMaterno = reader["APELLIDOMATERNO"].ToString();
                    cons.direccion = reader["DIRECCION"].ToString();
                    cons.telefono = reader["TELEFONO"].ToString();
                    cons.email = reader["EMAIL"].ToString();
                    cons.isActivo = short.Parse(reader["ISACTIVO"].ToString());
                    cons.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    cons.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    cons.isRecibeOfertas = short.Parse(reader["ISRECIBEOFERTAS"].ToString());
                    cons.idCiudad = long.Parse(reader["CIUDAD_IDCIUDAD"].ToString());
                    cons.idUsuario = long.Parse(reader["USUARIO_IDUSUARIO"].ToString());
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return cons;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public int getTotalConsumidoresRegistrados()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM CONSUMIDOR";
                OracleDataReader reader = command.ExecuteReader();

                int countConsumidores = 0;

                while (reader.Read())
                {
                    countConsumidores = Convert.ToInt32(reader["COUNT(*)"]);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return countConsumidores;
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

        public static void enviarEMailNuevaOferta(string nombreProducto)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT NOMBRE, EMAIL FROM consumidor WHERE ISACTIVO = 1 AND ISRECIBEOFERTAS = 1";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Model.Negocio.Utils.Email.enviarMailOferta(reader["NOMBRE"].ToString(), reader["EMAIL"].ToString(), nombreProducto);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();
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
