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

namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    public partial class CrearTienda : Form
    {
        public CrearTienda()
        {
            InitializeComponent();
        }

        private void CrearTienda_Load(object sender, EventArgs e)
        {
            cargarCiudades();
        }

        void cargarCiudades()
        {
            cmbCiudad.DataSource = null;
            CiudadDAO listaCiudades = new CiudadDAO();
            cmbCiudad.DataSource = listaCiudades.listarCiudades();
            cmbCiudad.ValueMember = "IDCIUDAD";
            cmbCiudad.DisplayMember = "NOMBRE";
        }

        private void btnCrearTienda_Click(object sender, EventArgs e)
        {
            try
            {
                TiendaDAO lstTienda = new TiendaDAO();
                String nombre = txtNombreTienda.Text;
                String direccion = txtDireccionTienda.Text;
                String telefono = txtTelefonoTienda.Text;
                sbyte activo = 1;
                DateTime fechaCreacion = dtFechaIngresoTienda.Value;
                DateTime fechaModificacion = DateTime.Now;
                String empresa = txtNombreEmpresa.Text;
                Int16 Ciudad = Int16.Parse(cmbCiudad.SelectedValue.ToString());
                TiendaDAO insertarTienda = new TiendaDAO();
                insertarTienda.InsertaTienda(nombre, direccion, telefono, activo, fechaCreacion, fechaModificacion, empresa, Ciudad);
                MessageBox.Show("Tienda registrada exitosamente.");
                limpiarCampos();
                PortadaMantenedorTienda TiendaView = new PortadaMantenedorTienda();
                TiendaView.cargaTiendas();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: se ha generado un error en el sistema. Por favor intenta mas tarde o contacta al Administrador.");
            }
        }

        void limpiarCampos()
        {
            txtNombreTienda.Text = "";
            txtDireccionTienda.Text = "";
            cmbCiudad.SelectedIndex = 0;
            txtTelefonoTienda.Text = "";
            txtNombreEmpresa.Text = "";
        }

        private void btnCancelarTienda_Click(object sender, EventArgs e)
        {
            PortadaMantenedorTienda TiendaView = new PortadaMantenedorTienda();
            limpiarCampos();
            TiendaView.Refresh();
            this.Visible = false;
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
            if (txtDireccionTienda.Text.Equals("Dirección"))
            {
                txtDireccionTienda.Text = "";
                txtDireccionTienda.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoTienda_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoTienda.Text == null || txtTelefonoTienda.Text.Trim().Equals(string.Empty))
            {
                txtTelefonoTienda.Text = "Teléfono ## ### ####";
                txtTelefonoTienda.ForeColor = Color.Gray;
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

        private void txtTelefonoTienda_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoTienda.Text.Equals("Teléfono ## ### ####"))
            {
                txtTelefonoTienda.Text = "";
                txtTelefonoTienda.ForeColor = Color.Black;
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
    }
}
