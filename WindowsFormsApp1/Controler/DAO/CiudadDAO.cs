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
    class CiudadDAO
    {
        public DataTable getCiudadesCbx()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT IDCIUDAD, NOMBRE FROM Ciudad WHERE ISACTIVO = :registroActivo";
                cmd.Parameters.Add(":registroActivo", OracleDbType.Int16).Value = 1;
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable("Ciudades");
                oda.Fill(dataTable);

                return dataTable;
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

        public List<Ciudad> listarCiudades()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM CIUDAD where isactivo = 1";
                OracleDataReader dr = command.ExecuteReader();

                List<Ciudad> lstCiudad = new List<Ciudad>();

                while (dr.Read())
                {
                    Ciudad entCiudad = new Ciudad();
                    entCiudad.nombre = (string)dr["NOMBRE"];
                    entCiudad.idCiudad = Int16.Parse(dr["IDCIUDAD"].ToString());
                    lstCiudad.Add(entCiudad);
                }

                dr.Close();
                command.Dispose();
                return lstCiudad;
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
