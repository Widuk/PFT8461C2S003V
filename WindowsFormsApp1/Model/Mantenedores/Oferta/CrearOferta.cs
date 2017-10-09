using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Negocio.Constantes;

namespace WindowsFormsApp1.Model.Mantenedores.Oferta
{
    public partial class CrearOferta : Form
    {
        public CrearOferta()
        {
            InitializeComponent();
        }

        private void btnCancelarTienda_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CrearOferta_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoDAO prodDAO = new ProductoDAO();
                DataTable dt = prodDAO.getProductosCbx();
                this.cbxProducto.DataSource = dt;
                this.cbxProducto.DisplayMember = "NOMBRE";
                this.cbxProducto.ValueMember = "IDPRODUCTO";

                TiendaDAO tiendaDAO = new TiendaDAO();
                DataTable dtTienda = tiendaDAO.getTiendasCbx();
                ((ListBox)this.chkListBoxTiendas).DataSource = dtTienda;
                ((ListBox)this.chkListBoxTiendas).DisplayMember = "NOMBRE";
                ((ListBox)this.chkListBoxTiendas).ValueMember = "IDTIENDA";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave Cargando datos para creación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                    this.txtUrlImagen.Text = open.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave Cargando imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearOferta_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Compare(this.dtpFechaInicio.Value.Date, this.dtpFechaFin.Value.Date) > 0 || DateTime.Compare(this.dtpFechaInicio.Value.Date, this.dtpFechaFin.Value.Date) == 0)
                {
                    MessageBox.Show("Error: La fecha de inicio debe ser anterior a la fecha de fin de la Oferta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (this.txtUrlImagen.Text == null || this.txtUrlImagen.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: Se debe adjuntar una imagen a la Oferta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (this.nudCantMaxProd.Value < this.nudCantMinProd.Value)
                {
                    MessageBox.Show("Error: La cantidad máxima de productos debe ser mayor a la cantidad mínima.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (this.nudCantMaxProd.Value == 0 || this.nudCantMinProd.Value == 0)
                {
                    MessageBox.Show("Error: La cantidad de productos mínimos y máximos debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (this.chkListBoxTiendas.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Error: Se debe seleccionar al menos una Tienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    OfertaDAO ofertaDAO = new OfertaDAO();
                    Negocio.Entities.Oferta ofer = ofertaDAO.getOfertaVigenteByCodigoProducto(int.Parse(cbxProducto.SelectedValue.ToString()));

                    if (ofer != null)
                    {
                        MessageBox.Show("Error: Ya existe una oferta creada para el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Creamos los objetos.
                    Negocio.Entities.Oferta nuevaOferta = new Negocio.Entities.Oferta();
                    nuevaOferta.fechaInicio = this.dtpFechaInicio.Value;
                    nuevaOferta.fechaFin = this.dtpFechaFin.Value;
                    nuevaOferta.idProducto = long.Parse(this.cbxProducto.SelectedValue.ToString());
                    nuevaOferta.isPublicada = 0;
                    nuevaOferta.minimoProductos = (int)this.nudCantMinProd.Value;
                    nuevaOferta.maximoProductos = (int)this.nudCantMaxProd.Value;
                    nuevaOferta.rutaFoto = Constantes.rutaBaseFotos + this.txtUrlImagen.Text.Split('\\')[this.txtUrlImagen.Text.Split('\\').Length - 1];

                    List<long> listaTiendas = new List<long>();

                    for(int i = 0; i < this.chkListBoxTiendas.CheckedItems.Count; i++)
                    {
                        listaTiendas.Add(long.Parse(((DataRowView)this.chkListBoxTiendas.CheckedItems[i])["IDTIENDA"].ToString()));   
                    }

                    ofertaDAO.crearOferta(nuevaOferta);
                    
                    foreach(long l in listaTiendas)
                    {
                        ofertaDAO.creaRelacionOfertaProducto(nuevaOferta.idOferta, l);
                    }           

                    this.Dispose();

                    MessageBox.Show("Oferta creada exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave Creando Oferta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally
            {

            }
        }
    }
}
