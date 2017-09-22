using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.Vo;

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

        public List<UsuarioGridVO> getListaUsuariosTrabajadores()
        {
            OracleConnection conn = Conexion.Connect();
            List<UsuarioGridVO> listaUsuarios = new List<UsuarioGridVO>();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT u.IDUSUARIO,u.LOGIN,u.ISACTIVO,u.FECHACREACION,u.FECHAMODIFICACION,tr.NOMBRE,tr.APELLIDOPATERNO,tr.APELLIDOMATERNO,tr.RUT,tr.DV, per.NOMBRE as NOMBREPERFIL FROM Usuario u INNER JOIN Trabajador tr ON u.idusuario = tr.usuario_idusuario INNER JOIN Perfil per ON per.IDPERFIL = u.PERFIL_IDPERFIL";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UsuarioGridVO usuarioGrid = new UsuarioGridVO();
                    usuarioGrid.idUsuario = long.Parse(reader["IDUSUARIO"].ToString());
                    usuarioGrid.login = reader["LOGIN"].ToString();
                    usuarioGrid.estado = short.Parse(reader["ISACTIVO"].ToString()) == 1 ? "Activo" : "Inactivo";
                    usuarioGrid.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    usuarioGrid.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    usuarioGrid.nombre = reader["NOMBRE"].ToString();
                    usuarioGrid.apellidoPaterno = reader["APELLIDOPATERNO"].ToString();
                    usuarioGrid.apellidoMaterno = reader["APELLIDOMATERNO"].ToString();
                    usuarioGrid.rut = reader["RUT"].ToString() + reader["DV"].ToString().ToUpper();
                    usuarioGrid.tipoUsuario = "Trabajador";
                    usuarioGrid.perfil = reader["NOMBREPERFIL"].ToString();
                    listaUsuarios.Add(usuarioGrid);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return listaUsuarios;
            }catch(Exception e){
                throw new Exception(e.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public List<UsuarioGridVO> getListaUsuariosConsumidores()
        {
            OracleConnection conn = Conexion.Connect();
            List<UsuarioGridVO> listaUsuarios = new List<UsuarioGridVO>();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT u.IDUSUARIO,u.LOGIN,u.ISACTIVO,u.FECHACREACION,u.FECHAMODIFICACION,tr.NOMBRE,tr.APELLIDOPATERNO,tr.APELLIDOMATERNO,tr.RUT,tr.DV, per.NOMBRE as NOMBREPERFIL FROM Usuario u INNER JOIN Consumidor tr ON u.idusuario = tr.usuario_idusuario INNER JOIN Perfil per ON per.IDPERFIL = u.PERFIL_IDPERFIL";
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UsuarioGridVO usuarioGrid = new UsuarioGridVO();
                    usuarioGrid.idUsuario = long.Parse(reader["IDUSUARIO"].ToString());
                    usuarioGrid.login = reader["LOGIN"].ToString();
                    usuarioGrid.estado = short.Parse(reader["ISACTIVO"].ToString()) == 1 ? "Activo" : "Inactivo";
                    usuarioGrid.fechaCreacion = DateTime.Parse(reader["FECHACREACION"].ToString());
                    usuarioGrid.fechaModificacion = DateTime.Parse(reader["FECHAMODIFICACION"].ToString());
                    usuarioGrid.nombre = reader["NOMBRE"].ToString();
                    usuarioGrid.apellidoPaterno = reader["APELLIDOPATERNO"].ToString();
                    usuarioGrid.apellidoMaterno = reader["APELLIDOMATERNO"].ToString();
                    usuarioGrid.rut = reader["RUT"].ToString() + reader["DV"].ToString().ToUpper();
                    usuarioGrid.tipoUsuario = "Consumidor";
                    usuarioGrid.perfil = reader["NOMBREPERFIL"].ToString();
                    listaUsuarios.Add(usuarioGrid);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return listaUsuarios;
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
