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
                if(DateTime.Compare(this.dtpFechaInicio.Value, this.dtpFechaFin.Value) < 0 || DateTime.Compare(this.dtpFechaInicio.Value, this.dtpFechaFin.Value) == 0)
                {
                    MessageBox.Show("Error: La fecha de inicio de la oferta debe ser menor a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
