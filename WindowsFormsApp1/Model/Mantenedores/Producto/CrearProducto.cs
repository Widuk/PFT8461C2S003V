using System;
using System.Data;
using System.Drawing;
using PresentationControls;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using System.Collections;
using System.Collections.Generic;

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
            TiendaDAO listaTiendaDT = new TiendaDAO();
            cmbTienda.DataSource = listaTiendaDT.ListarTiendaDT();
            DataTable DT = listaTiendaDT.ListarTiendaDT();
            cmbTienda.DataSource = new ListSelectionWrapper<DataRow>(DT.Rows,true, "NOMBRE");
            cmbTienda.DisplayMemberSingleItem = "Name";
            cmbTienda.DisplayMember = "NameConcatenated";
            cmbTienda.ValueMember = "Selected";
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
            if (validaCampos())
            {
                try
                {
                    int m = 0;
                    for (int f = 0; f < cmbTienda.Items.Count; f++)
                    {
                        if (cmbTienda.CheckBoxItems[f].Checked == true)
                        {
                            m = m + 1;
                        }
                    }
                    if (m == 0)
                    {
                        MessageBox.Show("Debe ingresar al menos una tienda.");cmbTienda.Focus();
                        return;
                    }
                    //m = m - 1;
                    string[] arreglo = new string[m];
                    
                    string s = string.Empty;
                    int cont = 0;
                    for (int x = 0; x < cmbTienda.Items.Count; x++)
                    {
                        if (cmbTienda.CheckBoxItems[x].Checked == true)
                        {
                            s = cmbTienda.CheckBoxItems[x].Text;
                            s = s.Replace(" [0]", "");
                            arreglo[cont] = s;
                            cont = cont + 1;
                        }
                    }

                    ProductoDAO prodDao = new ProductoDAO();
                    String sku = txtSKU.Text;
                    String nombre = txtNombre.Text.ToUpper();
                    String precio = txtPrecio.Text;
                    sbyte activo = 0;
                    if (cmbActivo.Text.Equals("Activo")) { activo = 1; activo = 0; }
                    Int16 rubro = Int16.Parse(cmbRubro.SelectedValue.ToString());
                    String descripcion = txtDescripcion.Text;
                    String promocion = cbPermitePromocion.Checked.ToString();
                    if (promocion == "True") { promocion = "1"; } else { promocion = "0"; }

                    Boolean skuExistente = prodDao.buscaProductoPorSku(sku);
                    if (!skuExistente)
                    {
                        prodDao.InsertaProducto(nombre, descripcion, precio, promocion, sku, activo, DateTime.Now, rubro);
                    }
                    else
                    {
                        MessageBox.Show("El SKU del producto ya se encuentra ingresado.");
                        return;
                    }

                    int idProducto = prodDao.buscaProductoPorNombre(nombre,sku);

                    for (int x = 0; x < arreglo.Length; x++)
                    {
                        TiendaDAO tiDAO = new TiendaDAO();
                        int idTienda = tiDAO.buscaIdTiendaPorNombre2(arreglo[x]);
                        prodDao.guardaProductoTienda(idProducto, idTienda);
                    }
                    

                    MessageBox.Show("Creación de producto exitosa.");
                    limpiarCampos();
                    PortadaMantenedorProducto ProductoView = new PortadaMantenedorProducto();
                    ProductoView.Refresh();
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un problema creando el producto. Por favor intenta mas tarde o contacta a soporte.");
                    return;
                }
            }
        }
        Boolean validaCampos()
        {
            Boolean valido = false;
            if (txtSKU.Text == null || txtSKU.Text.Trim().Equals(string.Empty) || txtSKU.Text.Trim().Equals("SKU"))
            {
                MessageBox.Show("SKU del producto oligatorio.");
                txtSKU.Focus();
                return valido;
            }
            if (txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty) || txtNombre.Text.Trim().Equals("Nombre"))
            {
                MessageBox.Show("Nombre del producto oligatorio.");
                txtNombre.Focus();
                return valido;
            }
            if (txtPrecio.Text == null || txtPrecio.Text.Trim().Equals(string.Empty) || txtPrecio.Text.Trim().Equals("Precio"))
            {
                MessageBox.Show("Precio del producto oligatorio.");
                txtPrecio.Focus();
                return valido;
            }
            if (cmbActivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si el producto estará activo.");
                cmbActivo.Focus();
                return valido;
            }
            //if (cmbTienda.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Tienda del producto obligatoria.");
            //    cmbTienda.Focus();
            //    return valido;
            //}
            if (cmbRubro.SelectedIndex == -1)
            {
                MessageBox.Show("El rubro del producto es oligatorio.");
                cmbRubro.Focus();
                return valido;
            }
            return valido = true;
        }
    }
}
