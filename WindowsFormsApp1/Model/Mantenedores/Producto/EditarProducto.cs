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
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            try
            {

                Int16 x = Int16.Parse(objetoPaso.paso0);                        //id
                Int16 j;
                if (chDisponiblidad.Checked == true) { j = 1; } else { j = 0; }; //2X1
                Int16 i;
                if (cmbEstado.Text == "Activo") { i = 1; } else { i = 0; };         //estado

                ProductoDAO editaProducto = new ProductoDAO();
                editaProducto.EditarProducto(x, txtNombreTienda.Text, txtDescripcion.Text, txtPrecio.Text, j, txtSku.Text, i, DateTime.Now, Int16.Parse(cmbTienda.SelectedValue.ToString()), Int16.Parse(cmbRubro.SelectedValue.ToString()));
                MessageBox.Show("Modificación de producto exitosa.");
                PortadaMantenedorProducto ProductoView = new PortadaMantenedorProducto();
                ProductoView.cargaProductos();
                this.Visible = false;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error al modificar el producto.");
            }
        }

        private void btnCancelarTienda_Click(object sender, EventArgs e)
        {
            PortadaMantenedorProducto ProductoView = new PortadaMantenedorProducto();
            limpiarCampos();
            ProductoView.cargaProductos();
            this.Visible = false;
        }
        void limpiarCampos()
        {
            dtFechaIngresoTienda.Value = DateTime.Now;
            txtNombreTienda.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtSku.Text = "";
            cmbTienda.SelectedIndex = -1;
            cmbRubro.SelectedIndex = 0;
            cmbEstado.SelectedIndex = -1;
            chDisponiblidad.Checked = true;
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            cargaProductosEditar();
            cargaRubro();
            cargaTiendas();
        }

        void cargaProductosEditar()
        {
            Boolean check = false;
            txtNombreTienda.Text = objetoPaso.paso1;    //nombre
            txtDescripcion.Text = objetoPaso.paso2;    //descripcion
            txtPrecio.Text = objetoPaso.paso3;    //precio
            txtSku.Text = objetoPaso.paso5;    //sku
            cmbTienda.SelectedValue = objetoPaso.paso9;    //tienda
            cmbRubro.SelectedValue = objetoPaso.paso10;    //rubro
            cmbEstado.SelectedIndex = Int16.Parse(objetoPaso.paso6);    //estado

            if (objetoPaso.paso4 == "1") { check = true; } else { check = false; };
            chDisponiblidad.Checked = check;    //2X1
        }

        void cargaRubro()
        {
            cmbRubro.DataSource = null;
            RubroDAO rubro = new RubroDAO();
            cmbRubro.DataSource = rubro.listarRubros();
            cmbRubro.ValueMember = "IDRUBRO";
            cmbRubro.DisplayMember = "NOMBRE";
        }

        void cargaTiendas()
        {
            cmbTienda.DataSource = null;
            TiendaDAO tienda = new TiendaDAO();
            cmbTienda.DataSource = tienda.listarTiendas();
            cmbTienda.ValueMember = "IDTIENDA";
            cmbTienda.DisplayMember = "NOMBRE";
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
