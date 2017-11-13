using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;

namespace WindowsFormsApp1.Controler.DAO
{
    class ValoracionDAO
    {
        public int getTotalValoracionesRegistradas()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM VALORACION";
                OracleDataReader reader = command.ExecuteReader();

                int countValoracion = 0;

                while (reader.Read())
                {
                    countValoracion = Convert.ToInt32(reader["COUNT(*)"]);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return countValoracion;
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
