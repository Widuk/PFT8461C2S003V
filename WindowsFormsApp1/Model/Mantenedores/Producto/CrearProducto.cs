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

namespace WindowsFormsApp1
{
    public partial class CrearProducto : Form
    {
        public CrearProducto()
        {
            InitializeComponent();
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {
            cargarTiendas();
            cargarRubro();
        }

        void cargarRubro()
        {
            cmbRubro.DataSource = null;
            RubroDAO listaRubro = new RubroDAO();
            cmbRubro.DataSource = listaRubro.listarRubros();
            cmbRubro.ValueMember = "IDRUBRO";
            cmbRubro.DisplayMember = "NOMBRE";
        }
        void cargarTiendas()
        {
            cmbTienda.DataSource = null;
            TiendaDAO listaTiendas = new TiendaDAO();
            cmbTienda.DataSource = listaTiendas.listarTiendas();
            cmbTienda.ValueMember = "IDTIENDA";
            cmbTienda.DisplayMember = "NOMBRE";
        }

        public void limpiarCampos()
        {
            txtSKU.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbTienda.SelectedIndex = 0;
            cmbActivo.SelectedIndex = 0;
            txtDescripcion.Text = "";
            cmbRubro.SelectedIndex = 0;
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            PortadaMantenedorProducto ProductoView = new PortadaMantenedorProducto();
            limpiarCampos();
            ProductoView.cargaProductos();
            this.Visible = false;
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

        private void txtSKU_Leave(object sender, EventArgs e)
        {
            if (txtSKU.Text == null || txtSKU.Text.Trim().Equals(string.Empty))
            {
                txtSKU.Text = "SKU";
                txtSKU.ForeColor = Color.Gray;
            }
        }

        private void txtSKU_Enter(object sender, EventArgs e)
        {
            if (txtSKU.Text.Equals("SKU"))
            {
                txtSKU.Text = "";
                txtSKU.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == null || txtPrecio.Text.Trim().Equals(string.Empty))
            {
                txtPrecio.Text = "Precio";
                txtPrecio.ForeColor = Color.Gray;
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Equals("Precio"))
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == null || txtDescripcion.Text.Trim().Equals(string.Empty))
            {
                txtDescripcion.Text = "Descripción";
                txtDescripcion.ForeColor = Color.Gray;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals("Descripción"))
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoDAO lstProducto = new ProductoDAO();
                String sku = txtSKU.Text;
                String nombre = txtNombre.Text;
                String precio = txtPrecio.Text;
                Int16 estado = Int16.Parse(cmbActivo.SelectedIndex.ToString());
                Int16 tienda = Int16.Parse(cmbTienda.SelectedValue.ToString());
                Int16 rubro = Int16.Parse(cmbRubro.SelectedValue.ToString());
                String descripcion = txtDescripcion.Text;
                String promocion = cbPermitePromocion.Checked.ToString();
                if (promocion == "True") { promocion = "1"; } else { promocion = "0"; }
                sbyte activo = 1;

                ProductoDAO insertarProducto = new ProductoDAO();
                insertarProducto.InsertaProducto(nombre, descripcion, precio, promocion, sku, activo, DateTime.Now, DateTime.Now, tienda, rubro);
                MessageBox.Show("Creación de producto exitosa.");
                limpiarCampos();
                PortadaMantenedorProducto ProductoView = new PortadaMantenedorProducto();
                ProductoView.Refresh();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema creando el producto. Por favor intenta mas tarde o contacta a soporte.");
            }
        }
    }
}
