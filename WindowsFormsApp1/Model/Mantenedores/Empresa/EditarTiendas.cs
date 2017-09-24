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

namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    public partial class EditarTiendas : Form
    {
        public EditarTiendas()
        {
            InitializeComponent();
        }

        private void EditarTiendas_Load(object sender, EventArgs e)
        {
            CargaDatosTienda();
            cargaCiudades();
        }
        void CargaDatosTienda()
        {
            txtNombreTienda.Text = objetoPaso.paso1;
            txtDireccionTienda.Text = objetoPaso.paso2;
            cmbCiudad.SelectedValue = objetoPaso.paso8;
            txtTelefonoTienda.Text = objetoPaso.paso3;
            txtNombreEmpresa.Text = objetoPaso.paso7;
        }

        void cargaCiudades()
        {
            cmbCiudad.DataSource = null;
            CiudadDAO ciudad = new CiudadDAO();
            cmbCiudad.DataSource = ciudad.listarCiudades();
            cmbCiudad.ValueMember = "IDCIUDAD";
            cmbCiudad.DisplayMember = "NOMBRE";
        }
        private void txtNombreTienda_Leave(object sender, EventArgs e)
        {
            if (txtNombreTienda.Text == null || txtNombreTienda.Text.Trim().Equals(string.Empty))
            {
                txtNombreTienda.Text = "Nombre de la tienda";
                txtNombreTienda.ForeColor = Color.Gray;
            }
        }

        private void txtNombreTienda_Enter(object sender, EventArgs e)
        {
            if (txtNombreTienda.Text.Equals("Nombre de la tienda"))
            {
                txtNombreTienda.Text = "";
                txtNombreTienda.ForeColor = Color.Black;
            }
        }

        private void txtDireccionTienda_Leave(object sender, EventArgs e)
        {
            if (txtDireccionTienda.Text == null || txtDireccionTienda.Text.Trim().Equals(string.Empty))
            {
                txtDireccionTienda.Text = "Dirección";
                txtDireccionTienda.ForeColor = Color.Gray;
            }
        }

        private void txtDireccionTienda_Enter(object sender, EventArgs e)
        {
            if (txtDireccionTienda.Text.Equals("Descripción"))
            {
                txtDireccionTienda.Text = "";
                txtDireccionTienda.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoTienda_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoTienda.Text == null || txtTelefonoTienda.Text.Trim().Equals(string.Empty))
            {
                txtTelefonoTienda.Text = "Telefono ## ### ####";
                txtTelefonoTienda.ForeColor = Color.Gray;
            }
        }

        private void txtTelefonoTienda_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoTienda.Text.Equals("Telefono ## ### ####"))
            {
                txtTelefonoTienda.Text = "";
                txtTelefonoTienda.ForeColor = Color.Black;
            }
        }

        private void txtNombreEmpresa_Leave(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text == null || txtNombreEmpresa.Text.Trim().Equals(string.Empty))
            {
                txtNombreEmpresa.Text = "Nombre de empresa";
                txtNombreEmpresa.ForeColor = Color.Gray;
            }
        }

        private void txtNombreEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text.Equals("Nombre de empresa"))
            {
                txtNombreEmpresa.Text = "";
                txtNombreEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoTienda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 x = Int16.Parse(objetoPaso.paso0);                        //id
                TiendaDAO editaTienda = new TiendaDAO();
                editaTienda.EditarTienda(x, txtNombreTienda.Text, txtDireccionTienda.Text, txtTelefonoTienda.Text, dtFechaIngresoTienda.Value, txtNombreEmpresa.Text, Int16.Parse(cmbCiudad.SelectedValue.ToString()));
                MessageBox.Show("Modificación de tienda exitosa.");
                PortadaMantenedorTienda tiendaView = new PortadaMantenedorTienda();
                tiendaView.cargaTiendas();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la tienda.");
            }
        }
    }
}
