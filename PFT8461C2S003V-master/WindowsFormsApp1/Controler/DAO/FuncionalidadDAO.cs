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
    class FuncionalidadDAO
    {
        public List<Funcionalidad> getFuncionalidadesPorPerfil(long idPerfil)
        {
            OracleConnection conn = Conexion.Connect();
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select fu.* from funcionalidad fu INNER JOIN RL_FUNC_PERFIL fp ON fu.IDFUNCIONALIDAD = fp.FUNCIONALIDAD_IDFUNCIONALIDAD WHERE fp.PERFIL_IDPERFIL = :idPerfil AND fu.ISESCRITORIO = 1";
                cmd.Parameters.Add(":idPerfil", OracleDbType.Int32).Value = idPerfil;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Funcionalidad func = new Funcionalidad();
                    func.idFuncionalidad = long.Parse(reader["IDFUNCIONALIDAD"].ToString());
                    func.nombre = reader["NOMBRE"].ToString();
                    func.descripcion = reader["DESCRIPCION"].ToString();
                    func.isActivo = short.Parse(reader["ISACTIVO"].ToString());
                    func.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    func.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    func.isWeb = short.Parse(reader["ISWEB"].ToString());
                    func.isEscritorio = short.Parse(reader["ISESCRITORIO"].ToString());
                    funcionalidades.Add(func);
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();

                return funcionalidades;
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
