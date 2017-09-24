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
    }
}
