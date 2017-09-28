using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Negocio.Vo;
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
            if (validaCampos() == true)
            {
                try
                {
                    Int16 x = Int16.Parse(objetoPaso.paso0);                        //id
                    Int16 j;
                    if (chDisponiblidad.Checked == true) { j = 1; } else { j = 0; }; //2X1
                    Int16 i;
                    if (cmbEstado.Text == "Activo") { i = 1; } else { i = 0; };         //estado

                    ProductoDAO editaProducto = new ProductoDAO();
                    editaProducto.EditarProducto(x, txtNombreTienda.Text, txtDescripcion.Text, Int64.Parse(txtPrecio.Text), j, txtSku.Text, i, DateTime.Now, Int16.Parse(cmbTienda.SelectedValue.ToString()), Int16.Parse(cmbRubro.SelectedValue.ToString()));
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
            cargaRubro();
            cargaTiendas();
            cargaProductosEditar();
        }

        void cargaProductosEditar()
        {
            ProductoGridVO prod = new ProductoGridVO();
            prod.idTienda = long.Parse(objetoPaso.paso11);
            prod.idRubro = long.Parse(objetoPaso.paso12);
            Boolean check = false;
            int x = 0;

            txtNombreTienda.Text = objetoPaso.paso1;    //nombre
            txtDescripcion.Text = objetoPaso.paso2;    //descripcion
            txtPrecio.Text = objetoPaso.paso3;    //precio
            txtSku.Text = objetoPaso.paso6;    //sku
            cmbTienda.SelectedValue = prod.idTienda;    //FECHA
            cmbRubro.SelectedValue = prod.idRubro;    //ACTIVO

            if (objetoPaso.paso7 == "1") { x = 0; } else { x = 1; };
            cmbEstado.SelectedIndex = x;    //estado

            if (objetoPaso.paso4 == "Si") { check = true; } else { check = false; };
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
            cmbTienda.DisplayMember = "NOMBRETIENDA";
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

        Boolean validaCampos()
        {
            Boolean valido = false;
            if (txtNombreTienda.Text == null || txtNombreTienda.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Nombre del producto oligatorio.");
                txtNombreTienda.Focus();
                return valido;
            }
            //if (txtDescripcion.Text == null || txtDescripcion.Text.Trim().Equals(string.Empty))
            //{
            //    MessageBox.Show("Nombre del producto oligatorio.");
            //    txtDescripcion.Focus();
            //    return valido;
            //}
            if (txtPrecio.Text == null || txtPrecio.Text.Trim().Equals(string.Empty) || txtPrecio.Text.Trim().Equals("1.234.567.890"))
            {
                MessageBox.Show("Precio del producto oligatorio.");
                txtPrecio.Focus();
                return valido;
            }
            if (txtSku.Text == null || txtSku.Text.Trim().Equals(string.Empty) || txtSku.Text.Trim().Equals("SKU"))
            {
                MessageBox.Show("SKU del producto oligatorio.");
                txtSku.Focus();
                return valido;
            }
            if (cmbTienda.SelectedIndex == -1)
            {
                MessageBox.Show("Tienda del producto obligatoria.");
                cmbTienda.Focus();
                return valido;
            }
            if (cmbRubro.SelectedIndex == -1)
            {
                MessageBox.Show("El rubro del producto es oligatorio.");
                cmbRubro.Focus();
                return valido;
            }
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si el producto estará activo.");
                cmbEstado.Focus();
                return valido;
            }
            return valido = true;
        }
    }
}
