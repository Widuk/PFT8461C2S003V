using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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
                    usu.idSession = !dr.IsDBNull(6) ? (string)dr["IDSESSION"] : "";
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
                    usuarioGrid.rut = reader["RUT"].ToString() + "-" + reader["DV"].ToString().ToUpper();
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
                    usuarioGrid.rut = reader["RUT"].ToString() + "-" + reader["DV"].ToString().ToUpper();
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

        public Usuario getUsuarioPorLogin(string loginUsuario)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM Usuario WHERE LOGIN = :loginUsuario";
                command.Parameters.Add(":loginUsuario", OracleDbType.Varchar2).Value = loginUsuario;
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
                    usu.idSession = !dr.IsDBNull(6) ? (string)dr["IDSESSION"] : "";
                    usu.codigoPerfil = long.Parse(dr["PERFIL_IDPERFIL"].ToString());
                }

                dr.Close();
                command.Dispose();
                return usu;
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

        public void crearUsuarioTrabajador(Usuario usu, Trabajador trab)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_crea_usuario_trabajador";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("RUTPARAM", OracleDbType.Int32).Value = trab.rut;
                cmd.Parameters.Add("DVPARAM", OracleDbType.Varchar2).Value = trab.dv;
                cmd.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = trab.nombre;
                cmd.Parameters.Add("APELLIDOPATERNOPARAM", OracleDbType.Varchar2).Value = trab.apellidoPaterno;
                cmd.Parameters.Add("APELLIDOMATERNOPARAM", OracleDbType.Varchar2).Value = trab.apellidoMaterno;
                cmd.Parameters.Add("DIRECCIONPARAM", OracleDbType.Varchar2).Value = trab.direccion;
                cmd.Parameters.Add("TELEFONOPARAM", OracleDbType.Varchar2).Value = trab.telefono;
                cmd.Parameters.Add("EMAILPARAM", OracleDbType.Varchar2).Value = trab.email;
                cmd.Parameters.Add("ISACTIVOPARAM", OracleDbType.Int16).Value = trab.isActivo;
                cmd.Parameters.Add("IDCIUDAD", OracleDbType.Int32).Value = trab.idCiudad;
                cmd.Parameters.Add("LOGINPARAM", OracleDbType.Varchar2).Value = usu.login;
                cmd.Parameters.Add("PASSWORDPARAM", OracleDbType.Varchar2).Value = usu.password;
                cmd.Parameters.Add("ISACTIVOUSUPARAM", OracleDbType.Varchar2).Value = usu.isActivo;
                cmd.Parameters.Add("IDSESSIONPARAM", OracleDbType.Varchar2).Value = usu.idSession;
                cmd.Parameters.Add("IDPERFILPARAM", OracleDbType.Int32).Value = usu.codigoPerfil;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

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

        public void editarUsuarioTrabajador(Usuario usu, Trabajador trab)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_edita_usuario_trabajador";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IDTRABAJADORPARAM", OracleDbType.Int32).Value = trab.idTrabajador;
                cmd.Parameters.Add("RUTPARAM", OracleDbType.Int32).Value = trab.rut;
                cmd.Parameters.Add("DVPARAM", OracleDbType.Varchar2).Value = trab.dv;
                cmd.Parameters.Add("NOMBREPARAM", OracleDbType.Varchar2).Value = trab.nombre;
                cmd.Parameters.Add("APELLIDOPATERNOPARAM", OracleDbType.Varchar2).Value = trab.apellidoPaterno;
                cmd.Parameters.Add("APELLIDOMATERNOPARAM", OracleDbType.Varchar2).Value = trab.apellidoMaterno;
                cmd.Parameters.Add("DIRECCIONPARAM", OracleDbType.Varchar2).Value = trab.direccion;
                cmd.Parameters.Add("TELEFONOPARAM", OracleDbType.Varchar2).Value = trab.telefono;
                cmd.Parameters.Add("EMAILPARAM", OracleDbType.Varchar2).Value = trab.email;
                cmd.Parameters.Add("ISACTIVOPARAM", OracleDbType.Int16).Value = trab.isActivo;
                cmd.Parameters.Add("IDCIUDAD", OracleDbType.Int32).Value = trab.idCiudad;
                cmd.Parameters.Add("IDUSUARIOPARAM", OracleDbType.Int32).Value = usu.idUsuario;
                cmd.Parameters.Add("LOGINPARAM", OracleDbType.Varchar2).Value = usu.login;
                cmd.Parameters.Add("PASSWORDPARAM", OracleDbType.Varchar2).Value = usu.password;
                cmd.Parameters.Add("ISACTIVOUSUPARAM", OracleDbType.Varchar2).Value = usu.isActivo;
                cmd.Parameters.Add("IDSESSIONPARAM", OracleDbType.Varchar2).Value = usu.idSession;
                cmd.Parameters.Add("IDPERFILPARAM", OracleDbType.Int32).Value = usu.codigoPerfil;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public int getTotalUsuariosRegistrados() {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand command = conn.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM USUARIO";
                OracleDataReader reader = command.ExecuteReader();

                int countUsuarios = 0;

                while (reader.Read())
                {
                    countUsuarios = Convert.ToInt32(reader["COUNT(*)"]);
                }

                command.Dispose();
                reader.Close();
                reader.Dispose();

                return countUsuarios;
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
