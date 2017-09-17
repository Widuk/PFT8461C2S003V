using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Conexion
{
    class Conexion
    {
        public static OracleConnection Connect()
        {
            OracleConnection con;
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost )(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));Password=1234;User ID=portafolio";
            con = new OracleConnection(connString);
            con.Open();
            return con;
        }
    }
}
