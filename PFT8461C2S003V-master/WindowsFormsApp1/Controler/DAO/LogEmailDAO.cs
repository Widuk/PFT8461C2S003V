using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;

namespace WindowsFormsApp1.Controler.DAO
{
    class LogEmailDAO
    {
        public int getTotalLogEmailEnviados()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM LOGEMAIL";
                OracleDataReader reader = command.ExecuteReader();

                int countLogEmail = 0;

                while (reader.Read())
                {
                    countLogEmail = Convert.ToInt32(reader["COUNT(*)"]);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return countLogEmail;
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
