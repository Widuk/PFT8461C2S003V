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
    class TrabajadorDAO
    {
        public Trabajador getTrabajadorPorIdUsuario(long idUsuario)
        {
            OracleConnection conn = Conexion.Connect();
            Trabajador trab = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Trabajador WHERE USUARIO_IDUSUARIO = :idUsuario";
                cmd.Parameters.Add(":idUsuario", OracleDbType.Int32).Value = idUsuario;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trab = new Trabajador();
                    trab.idTrabajador = long.Parse(reader["IDTRABAJADOR"].ToString());
                    trab.rut = int.Parse(reader["RUT"].ToString());
                    trab.dv = reader["DV"].ToString();
                    trab.nombre = reader["NOMBRE"].ToString();
                    trab.apellidoPaterno = reader["APELLIDOPATERNO"].ToString();
                    trab.apellidoMaterno = reader["APELLIDOMATERNO"].ToString();
                    trab.direccion = reader["DIRECCION"].ToString();
                    trab.telefono = reader["TELEFONO"].ToString();
                    trab.email = reader["EMAIL"].ToString();
                    trab.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    trab.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    trab.isActivo = short.Parse(reader["ISACTIVO"].ToString());
                    trab.idUsuario = long.Parse(reader["USUARIO_IDUSUARIO"].ToString());
                    trab.idCiudad = long.Parse(reader["CIUDAD_IDCIUDAD"].ToString());
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();

                return trab;
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
