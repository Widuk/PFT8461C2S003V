using System;
using System.Drawing;
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
            cargaCiudades();
            cargarcmbCiudad();
            CargaDatosTienda();            
        }
        void cargarcmbCiudad()
        {
            cmbCiudad.DataSource = null;
            CiudadDAO listaCiudad = new CiudadDAO();
            cmbCiudad.DataSource = listaCiudad.listarCiudades();
            cmbCiudad.ValueMember = "IDCIUDAD";
            cmbCiudad.DisplayMember = "NOMBRE";
        }
        void cargaCiudades()
        {
            cmbCiudad.DataSource = null;
            CiudadDAO ciudad = new CiudadDAO();
            cmbCiudad.DataSource = ciudad.listarCiudades();
            cmbCiudad.ValueMember = "IDCIUDAD";
            cmbCiudad.DisplayMember = "NOMBRE";
        }
        void CargaDatosTienda()
        {
            txtNombreTienda.Text = objetoPaso.paso1;
            txtDireccionTienda.Text = objetoPaso.paso2;
            Ciudad cd = new Ciudad();
            cd.idCiudad = long.Parse(objetoPaso.paso9);
            cmbCiudad.SelectedValue = cd.idCiudad;
            txtTelefonoTienda.Text = objetoPaso.paso4;
            txtNombreEmpresa.Text = objetoPaso.paso8;
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
                txtTelefonoTienda.Text = "Teléfono ## ### ####";
                txtTelefonoTienda.ForeColor = Color.Gray;
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
            TiendaDAO tiendaPorNombre = new TiendaDAO();
            Tienda ti = tiendaPorNombre.buscaTiendaPorNombre(txtNombreTienda.Text.Trim().ToUpper());
            if (validaCampos() == true)
            {
                if (ti != null)
                {
                    MessageBox.Show("Error: La tienda ya se encuentra ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreTienda.Text = "";
                    txtNombreTienda.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        long x = long.Parse(objetoPaso.paso0);                        //id
                        TiendaDAO editaTienda = new TiendaDAO();
                        editaTienda.EditarTienda(x, txtNombreTienda.Text.Trim().ToUpper(), txtDireccionTienda.Text, txtTelefonoTienda.Text, dtFechaIngresoTienda.Value, txtNombreEmpresa.Text, Int16.Parse(cmbCiudad.SelectedValue.ToString()));
                        MessageBox.Show("Modificación de tienda exitosa.");
                        objetoPaso.paso0 = (String)(0.ToString());
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

        Boolean validaCampos()
        {
            Boolean valido = false;
            if (txtNombreTienda.Text == null || txtNombreTienda.Text.Trim().Equals(string.Empty) || txtNombreTienda.Text.Trim().Equals("Nombre de la tienda"))
            {
                MessageBox.Show("Nombre de la tienda obligatorio.");
                txtNombreTienda.Focus();
                return valido;
            }
            if (txtDireccionTienda.Text == null || txtDireccionTienda.Text.Trim().Equals(string.Empty) || txtDireccionTienda.Text.Trim().Equals("Dirección"))
            {
                MessageBox.Show("Dirección de la tienda obligatorio.");
                txtDireccionTienda.Focus();
                return valido;
            }
            if (cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("La Ciudad es obligatoria.");
                cmbCiudad.Focus();
                return valido;
            }
            if (txtTelefonoTienda.Text == null || txtTelefonoTienda.Text.Trim().Equals(string.Empty) || txtTelefonoTienda.Text.Trim().Equals("Teléfono ## ### ####"))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                txtTelefonoTienda.Focus();
                return valido;
            }
            if (txtNombreEmpresa.Text == null || txtNombreEmpresa.Text.Trim().Equals(string.Empty) || txtNombreEmpresa.Text.Trim().Equals("Nombre de empresa"))
            {
                MessageBox.Show("Nombre de Empresa obligatorio.");
                txtNombreEmpresa.Focus();
                return valido;
            }
            return valido = true;
        }

        private void btnCancelarTienda_Click(object sender, EventArgs e)
        {
            PortadaMantenedorTienda ProductoView = new PortadaMantenedorTienda();
            ProductoView.cargaTiendas();
            this.Visible = false;
        }
    }
}