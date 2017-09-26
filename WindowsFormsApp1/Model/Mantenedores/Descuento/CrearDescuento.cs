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

namespace WindowsFormsApp1.Model.Mantenedores.Descuento
{
    public partial class CrearDescuento : Form
    {
        public CrearDescuento()
        {
            InitializeComponent();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("Nombre"))
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty))
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
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

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if(txtDescripcion.Text == null || txtDescripcion.Text.Trim().Equals(string.Empty))
            {
                txtDescripcion.Text = "Descripción";
                txtDescripcion.ForeColor = Color.Gray;
            }
        }

        private void CrearDescuento_Load(object sender, EventArgs e)
        {
            ProductoDAO productoDAO = new ProductoDAO();
            DataTable dt = productoDAO.getProductosCbx();
            this.cbxProducto.DataSource = dt;
            this.cbxProducto.DisplayMember = "NOMBRE";
            this.cbxProducto.ValueMember = "IDPRODUCTO";
        }

        private void chkDescuentoPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuentoPorcentaje.Checked)
            {
                txtPorcentajeDescuento.Enabled = true;
                txtPorcentajeDescuento.Text = "";
                txtPorcentajeDescuento.ForeColor = Color.Black;

                chkDescuentoPrecio.Checked = false;

                txtPrecioDescuento.Enabled = false;
                txtPrecioDescuento.Text = "$0";
                txtPrecioDescuento.ForeColor = Color.Gray;
            }else
            {
                txtPorcentajeDescuento.Enabled = false;
                txtPorcentajeDescuento.Text = "0%";
                txtPorcentajeDescuento.ForeColor = Color.Gray;
            }
        }

        private void chkDescuentoPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuentoPrecio.Checked)
            {
                txtPrecioDescuento.Enabled = true;
                txtPrecioDescuento.Text = "";
                txtPrecioDescuento.ForeColor = Color.Black;

                chkDescuentoPorcentaje.Checked = false;

                txtPorcentajeDescuento.Enabled = false;
                txtPorcentajeDescuento.Text = "0%";
                txtPorcentajeDescuento.ForeColor = Color.Gray;
            }
            else
            {
                txtPrecioDescuento.Enabled = false;
                txtPrecioDescuento.Text = "$0";
                txtPrecioDescuento.ForeColor = Color.Gray;
            }
        }

        private void txtPorcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones varias
                if (txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty) || (txtNombre.Text.Trim().Equals("Nombre") && txtNombre.ForeColor == Color.Gray))
                {
                    MessageBox.Show("Error: El Nombre del descuento es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else if (txtDescripcion.Text == null || txtDescripcion.Text.Trim().Equals(string.Empty) || (txtDescripcion.Text.Trim().Equals("Descripción") && txtDescripcion.ForeColor == Color.Gray))
                {
                    MessageBox.Show("Error: La Descripción del descuento es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
                }
                else if (cbxProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Error: Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!chkDescuentoPorcentaje.Checked && !chkDescuentoPrecio.Checked)
                {
                    MessageBox.Show("Error: Debe seleccionar un tipo de descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chkDescuentoPorcentaje.Checked && (txtPorcentajeDescuento.Text == null || txtPorcentajeDescuento.Text.Trim().Equals(string.Empty) || (txtPorcentajeDescuento.Text.Trim().Equals("0%"))))
                {
                    MessageBox.Show("Error: Debe ingresar un porcentaje de descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(chkDescuentoPrecio.Checked && (txtPrecioDescuento.Text == null || txtPrecioDescuento.Text.Trim().Equals(string.Empty) || (txtPrecioDescuento.Text.Trim().Equals("$0"))))
                {
                    MessageBox.Show("Error: Debe ingresar un precio de descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    ProductoDAO productoDAO = new ProductoDAO();
                    DescuentoDAO descuentoDAO = new DescuentoDAO();
                    Producto prod = productoDAO.getProductoPorID(long.Parse(cbxProducto.SelectedValue.ToString()));

                    if(chkDescuentoPrecio.Checked && (prod.precio < int.Parse(txtPrecioDescuento.Text)))
                    {
                        MessageBox.Show("Error: El descuento por precio ingresado no puede superar el precio del producto: " + prod.precio + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if(chkDescuentoPorcentaje.Checked && (double.Parse(txtPorcentajeDescuento.Text) == 0 || double.Parse(txtPorcentajeDescuento.Text) > 100))
                    {
                        MessageBox.Show("Error: El Porcentaje de Descuento debe estar entre 1 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    WindowsFormsApp1.Model.Negocio.Entities.Descuento descOriginal = descuentoDAO.obtenerDescuentoPorProducto(prod.idProducto);

                    if(descOriginal == null)
                    {
                        WindowsFormsApp1.Model.Negocio.Entities.Descuento desc = new WindowsFormsApp1.Model.Negocio.Entities.Descuento();
                        desc.nombre = txtNombre.Text.Trim();
                        desc.descripcion = txtDescripcion.Text.Trim();
                        desc.isPorcentaje = chkDescuentoPorcentaje.Checked ? (short)1 : (short)0;
                        desc.porcentajeDescuento = desc.isPorcentaje == 1 ? double.Parse(txtPorcentajeDescuento.Text) : 0;
                        desc.isPrecioDirecto = chkDescuentoPrecio.Checked ? (short)1 : (short)0;
                        desc.precioDescuento = desc.isPrecioDirecto == 1 ? int.Parse(txtPrecioDescuento.Text) : 0;
                        desc.idProducto = prod.idProducto;
                        descuentoDAO.crearDescuento(desc);

                        this.Dispose();

                        MessageBox.Show("Descuento creado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Error: Ya existe un descuento creado para este Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave creando Descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
