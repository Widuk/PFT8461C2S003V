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
    class RubroDAO
    {
        public List<Rubro> listarRubros()
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM RUBRO";
                OracleDataReader dr = command.ExecuteReader();

                List<Rubro> lstRubro = new List<Rubro>();

                while (dr.Read())
                {
                    Rubro entRubro = new Rubro();
                    entRubro.idRubro = int.Parse(dr["IDRUBRO"].ToString());
                    entRubro.nombre = (string)dr["NOMBRE"];
                    entRubro.descripcion = (string)dr["DESCRIPCION"];
                    entRubro.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    entRubro.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    entRubro.isActivo = sbyte.Parse(dr["ISACTIVO"].ToString());
                    lstRubro.Add(entRubro);
                }

                dr.Close();
                command.Dispose();
                return lstRubro;
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
        public List<Rubro> listarRubrosPorId(Int16 idRubro)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM RUBRO where idrubro = " + idRubro;
                OracleDataReader dr = command.ExecuteReader();

                List<Rubro> lstRubro = new List<Rubro>();

                while (dr.Read())
                {
                    Rubro entRubro = new Rubro();
                    entRubro.idRubro = int.Parse(dr["IDRUBRO"].ToString());
                    entRubro.nombre = (string)dr["NOMBRE"];
                    lstRubro.Add(entRubro);
                }

                dr.Close();
                command.Dispose();
                return lstRubro;
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
