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
    class UsuarioDAO
    {
        public Usuario getUsuarioPorCodigo(long codigoUsuario)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM USUARIO WHERE IDUSUARIO = :idUsuario";
                command.Parameters.Add(":idUsuario", OracleDbType.Int32).Value = codigoUsuario;
                OracleDataReader dr = command.ExecuteReader();

                Usuario usu = null;

                while (dr.Read())
                {
                    usu = new Usuario();
                    usu.idUsuario = long.Parse(dr["IDUSUARIO"].ToString());
                    usu.login = (string)dr["LOGIN"];
                    usu.password = (string)dr["PASSWORD"];
                    usu.isActivo = short.Parse(dr["ISACTIVO"].ToString());
                    usu.fechaCreacion = DateTime.Parse(dr["FECHACREACION"].ToString());
                    usu.fechaModificacion = DateTime.Parse(dr["FECHAMODIFICACION"].ToString());
                    usu.idSession = (string)dr["IDSESSION"];
                    usu.codigoPerfil = long.Parse(dr["PERFIL_IDPERFIL"].ToString());
                }

                dr.Close();
                command.Dispose();
                return usu;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
