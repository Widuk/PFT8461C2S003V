using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;

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
    }
}
