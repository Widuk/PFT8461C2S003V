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
    class OfertaDAO
    {
        public Oferta getOfertaVigenteByCodigoProducto(long codigoProducto)
        {
            OracleConnection conn = Conexion.Connect();
            Oferta oferta = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Oferta WHERE PRODUCTO_IDPRODUCTO = :codigoProducto AND FECHAFIN > :fechaActualFin AND FECHAINICIO < :fechaActualInicio";
                cmd.Parameters.Add(":codigoProducto", OracleDbType.Int32).Value = codigoProducto;
                cmd.Parameters.Add(":fechaActualFin", OracleDbType.Date).Value = new DateTime();
                cmd.Parameters.Add(":fechaActualInicio", OracleDbType.Date).Value = new DateTime();
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oferta = new Oferta();
                    oferta.idOferta = long.Parse(reader["IDOFERTA"].ToString());
                    oferta.fechaInicio = DateTime.Parse(reader["FECHAINICIO"].ToString());
                    oferta.fechaFin = DateTime.Parse(reader["FECHAFIN"].ToString());
                    oferta.fotografia = (byte[])reader["FOTOGRAFIA"];
                    oferta.minimoProductos = int.Parse(reader["MINIMOPRODUCTOS"].ToString());
                    oferta.maximoProductos = int.Parse(reader["MAXIMOPRODUCTOS"].ToString());
                    oferta.isPublicada = short.Parse(reader["ISPUBLICADA"].ToString());
                    oferta.idProducto = long.Parse(reader["PRODUCTO_IDPRODUCTO"].ToString());
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return oferta;
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
        
        public List<OfertaGridVO> getListaOfertasGrid()
        {
            OracleConnection conn = Conexion.Connect();
            List<OfertaGridVO> listaOfertas = new List<OfertaGridVO>();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select ofer.IDOFERTA, ofer.FECHAINICIO, ofer.FECHAFIN, ofer.MINIMOPRODUCTOS, ofer.MAXIMOPRODUCTOS, ofer.ISPUBLICADA, prod.NOMBRE, prod.SKU " +
                                  "from oferta ofer " +
                                  "inner join producto prod on ofer.PRODUCTO_IDPRODUCTO = prod.IDPRODUCTO";
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OfertaGridVO ofertaGrid = new OfertaGridVO();
                    ofertaGrid.idOferta = long.Parse(reader["IDOFERTA"].ToString());
                    ofertaGrid.fechaInicio = DateTime.Parse(reader["FECHAINICIO"].ToString());
                    ofertaGrid.fechaFin = DateTime.Parse(reader["FECHAFIN"].ToString());
                    ofertaGrid.minimoProductos = int.Parse(reader["MINIMOPRODUCTOS"].ToString());
                    ofertaGrid.maximoProductos = int.Parse(reader["MAXIMOPRODUCTOS"].ToString());
                    ofertaGrid.estado = short.Parse(reader["ISPUBLICADA"].ToString()) == (short)1 ? "Publicada" : "No Publicada";
                    ofertaGrid.nombreProducto = reader["NOMBRE"].ToString();
                    ofertaGrid.skuProducto = reader["SKU"].ToString();
                    listaOfertas.Add(ofertaGrid);
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();

                return listaOfertas;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                conn.Close();
                conn.Dispose();
            }
        }   
        
        public void crearOferta(Model.Negocio.Entities.Oferta oferta)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_crea_oferta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("FECHAINICIOPARAM", OracleDbType.Date).Value = oferta.fechaInicio;
                cmd.Parameters.Add("FECHAFINPARAM", OracleDbType.Date).Value = oferta.fechaFin;
                cmd.Parameters.Add("FOTOGRAFIAPARAM", OracleDbType.Blob).Value = oferta.fotografia;
                cmd.Parameters.Add("MINIMOPRODUCTOSPARAM", OracleDbType.Int32).Value = (int)oferta.minimoProductos;
                cmd.Parameters.Add("MAXIMOPRODUCTOSPARAM", OracleDbType.Int32).Value = (int)oferta.maximoProductos;
                cmd.Parameters.Add("ISPUBLICADAPARAM", OracleDbType.Int32).Value = (int)oferta.isPublicada;
                cmd.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int32).Value = (int)oferta.idProducto;
                cmd.Parameters.Add("IDOFERTAPARAM", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                oferta.idOferta = long.Parse(cmd.Parameters["IDOFERTAPARAM"].Value.ToString());
                cmd.Dispose();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        
        public void creaRelacionOfertaProducto(long idOferta, long codigoTienda)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO RL_OFERTA_TIENDA VALUES(:codigoOferta, :codigoTienda)";
                cmd.Parameters.Add(":codigoOferta", OracleDbType.Int32).Value = idOferta;
                cmd.Parameters.Add(":codigoTienda", OracleDbType.Int32).Value = codigoTienda;
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

        public List<RlOFertaTienda> getOfertasTiendas(long idOFerta)
        {
            OracleConnection conn = Conexion.Connect();
            List<RlOFertaTienda> listaOfertas = new List<RlOFertaTienda>();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ot.OFERTA_IDOFERTA, ot.TIENDA_IDTIENDA, t.NOMBRE FROM RL_OFERTA_TIENDA ot INNER JOIN TIENDA t ON ot.TIENDA_IDTIENDA = t.IDTIENDA WHERE OFERTA_IDOFERTA = :idOFerta";
                cmd.Parameters.Add(":idOferta", OracleDbType.Int32).Value = idOFerta;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RlOFertaTienda rlOfertaTienda = new RlOFertaTienda();
                    rlOfertaTienda.idOFerta = long.Parse(reader["OFERTA_IDOFERTA"].ToString());
                    rlOfertaTienda.idTienda = long.Parse(reader["TIENDA_IDTIENDA"].ToString());
                    rlOfertaTienda.nombreTienda = reader["NOMBRE"].ToString();
                    listaOfertas.Add(rlOfertaTienda);
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return listaOfertas;
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

        public Oferta getOfertaByCodigo(long codigoOferta)
        {
            OracleConnection conn = Conexion.Connect();
            Oferta oferta = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Oferta WHERE IDOFERTA = :codigoOferta";
                cmd.Parameters.Add(":codigoOferta", OracleDbType.Int32).Value = codigoOferta;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oferta = new Oferta();
                    oferta.idOferta = long.Parse(reader["IDOFERTA"].ToString());
                    oferta.fechaInicio = DateTime.Parse(reader["FECHAINICIO"].ToString());
                    oferta.fechaFin = DateTime.Parse(reader["FECHAFIN"].ToString());
                    oferta.fotografia = (byte[])reader["FOTOGRAFIA"];
                    oferta.minimoProductos = int.Parse(reader["MINIMOPRODUCTOS"].ToString());
                    oferta.maximoProductos = int.Parse(reader["MAXIMOPRODUCTOS"].ToString());
                    oferta.isPublicada = short.Parse(reader["ISPUBLICADA"].ToString());
                    oferta.idProducto = long.Parse(reader["PRODUCTO_IDPRODUCTO"].ToString());
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return oferta;
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

        public void actualizarOferta(Oferta oferta)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "sp_modifica_oferta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IDOFERTAPARAM", OracleDbType.Int32).Value = oferta.idOferta;
                cmd.Parameters.Add("FECHAINICIOPARAM", OracleDbType.Date).Value = oferta.fechaInicio;
                cmd.Parameters.Add("FECHAFINPARAM", OracleDbType.Date).Value = oferta.fechaFin;
                cmd.Parameters.Add("FOTOGRAFIAPARAM", OracleDbType.Blob).Value = oferta.fotografia;
                cmd.Parameters.Add("MINIMOPRODUCTOSPARAM", OracleDbType.Int32).Value = (int)oferta.minimoProductos;
                cmd.Parameters.Add("MAXIMOPRODUCTOSPARAM", OracleDbType.Int32).Value = (int)oferta.maximoProductos;
                //cmd.Parameters.Add("ISPUBLICADAPARAM", OracleDbType.Int32).Value = (int)oferta.isPublicada;
                cmd.Parameters.Add("IDPRODUCTOPARAM", OracleDbType.Int32).Value = (int)oferta.idProducto;
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

        public void eliminarRelacionOfertaTienda(long codigoOferta)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM RL_OFERTA_TIENDA WHERE OFERTA_IDOFERTA = :idOferta";
                cmd.Parameters.Add(":idOferta", OracleDbType.Int32).Value = codigoOferta;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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

        public void publicarOferta(long codigoOferta)
        {
            OracleConnection conn = Conexion.Connect();
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update Oferta set ispublicada = 1 WHERE IDOFERTA = :codigoOferta";
                cmd.Parameters.Add(":codigoOferta", OracleDbType.Int32).Value = codigoOferta;
                cmd.ExecuteReader();
                cmd.Dispose();
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

        public Oferta ofertaPublicada(long codigoOferta)
        {
            OracleConnection conn = Conexion.Connect();
            Oferta oferta = null;
            try
            {
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Oferta WHERE IDOFERTA = :codigoOferta";
                cmd.Parameters.Add(":codigoOferta", OracleDbType.Int32).Value = codigoOferta;
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    oferta = new Oferta();
                    oferta.isPublicada = short.Parse(reader["ISPUBLICADA"].ToString());
                }

                cmd.Dispose();
                reader.Close();
                reader.Dispose();

                return oferta;
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
