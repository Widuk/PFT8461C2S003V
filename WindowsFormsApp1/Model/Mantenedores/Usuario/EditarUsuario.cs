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
using WindowsFormsApp1.Model.Negocio.Utils;

namespace WindowsFormsApp1.Model.Mantenedores.Usuario
{
    public partial class EditarUsuario : Form
    {
        public WindowsFormsApp1.Model.Negocio.Entities.Usuario usuarioSeleccionado { get; set; }
        public Trabajador trabajadorSeleccionado { get; set; }
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                PerfilDAO perfilDAO = new PerfilDAO();
                DataTable dt = perfilDAO.getPerfilesCbx();
                this.cbxPerfil.DataSource = dt;
                this.cbxPerfil.DisplayMember = "NOMBRE";
                this.cbxPerfil.ValueMember = "IDPERFIL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ha ocurrido un error grave cargando los perfiles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                CiudadDAO ciudadDAO = new CiudadDAO();
                DataTable dt = ciudadDAO.getCiudadesCbx();
                this.cbxCiudad.DataSource = dt;
                this.cbxCiudad.DisplayMember = "NOMBRE";
                this.cbxCiudad.ValueMember = "IDCIUDAD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ha ocurrido un error grave cargando Ciudades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.txtNombre.Text = this.trabajadorSeleccionado.nombre.Trim();
            this.txtApellidoPaterno.Text = this.trabajadorSeleccionado.apellidoPaterno.Trim();
            this.txtApellidoMaterno.Text = this.trabajadorSeleccionado.apellidoMaterno.Trim();
            this.txtRut.Text = this.trabajadorSeleccionado.rut + "-" + this.trabajadorSeleccionado.dv;
            this.txtDireccion.Text = this.trabajadorSeleccionado.direccion.Trim();
            this.cbxCiudad.SelectedValue = this.trabajadorSeleccionado.idCiudad;
            this.cbxActivo.Checked = this.trabajadorSeleccionado.isActivo == 1 ? true : false;
            this.txtTelefono.Text = this.trabajadorSeleccionado.telefono.Trim();
            this.cbxPerfil.SelectedValue = this.usuarioSeleccionado.codigoPerfil;
            this.txtLogin.Text = this.usuarioSeleccionado.login.Trim().ToUpper();
            this.txtEmail.Text = this.trabajadorSeleccionado.email.Trim();

        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones varias
                if (txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                else if (txtApellidoPaterno.Text == null || txtApellidoPaterno.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Apellido paterno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApellidoPaterno.Focus();
                    return;
                }
                else if (txtApellidoMaterno.Text == null || txtApellidoMaterno.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Apellido materno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApellidoMaterno.Focus();
                    return;
                }
                else if (txtRut.Text == null || txtRut.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Rut es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRut.Focus();
                    return;
                }
                else if (txtDireccion.Text == null || txtDireccion.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La Dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDireccion.Focus();
                    return;
                }
                else if (txtTelefono.Text == null || txtTelefono.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefono.Focus();
                    return;
                }
                else if (txtLogin.Text == null || txtLogin.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Login es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                    return;
                }
                else if (txtEmail.Text == null || txtEmail.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Email es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                else if (txtContrasena.Text == null || txtContrasena.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La Contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    return;
                }
                else if (txtContrasena2.Text == null || txtContrasena2.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La confirmación de Contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena2.Focus();
                    return;
                }
                else if (!Utils.ValidaRut(txtRut.Text.Trim()))
                {
                    MessageBox.Show("Error: El Rut ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRut.Focus();
                    return;
                }
                else if (!Utils.IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Error: El Email ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    UsuarioDAO usuarioDAO = new UsuarioDAO();
                    if (!this.usuarioSeleccionado.login.Trim().Equals(txtLogin.Text.Trim()))
                    {
                        
                        WindowsFormsApp1.Model.Negocio.Entities.Usuario usu = usuarioDAO.getUsuarioPorLogin(txtLogin.Text.Trim().ToUpper());
                        if (usu != null)
                        {
                            MessageBox.Show("Error: El Login ingresado ya se encuentra utilizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLogin.Text = "";
                            txtLogin.Focus();
                            return;
                        }
                    }


                    if (!txtContrasena.Text.Trim().Equals(txtContrasena2.Text.Trim()))
                    {
                        MessageBox.Show("Error: Las Contraseñas ingresadas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Text = "";
                        txtContrasena2.Text = "";
                        txtContrasena.Focus();
                        return;
                    }

                    //Creación de nuevo usuario
                    WindowsFormsApp1.Model.Negocio.Entities.Usuario usuarioNuevo = new WindowsFormsApp1.Model.Negocio.Entities.Usuario();
                    usuarioNuevo.login = txtLogin.Text.Trim().ToUpper();
                    usuarioNuevo.password = Utils.EncodePassword(txtContrasena.Text.Trim());
                    usuarioNuevo.isActivo = cbxActivo.Checked ? (short)1 : (short)0;
                    usuarioNuevo.fechaCreacion = new DateTime();
                    usuarioNuevo.fechaModificacion = new DateTime();
                    usuarioNuevo.idSession = string.Empty;
                    usuarioNuevo.codigoPerfil = long.Parse(cbxPerfil.SelectedValue.ToString());
                    usuarioNuevo.idUsuario = this.usuarioSeleccionado.idUsuario;

                    //Creacion de nuevo Trabajador
                    Trabajador trab = new Trabajador();
                    trab.rut = int.Parse(txtRut.Text.Trim().Split('-')[0]);
                    trab.dv = txtRut.Text.Trim().Split('-')[1];
                    trab.nombre = txtNombre.Text.Trim();
                    trab.apellidoPaterno = txtApellidoPaterno.Text.Trim();
                    trab.apellidoMaterno = txtApellidoMaterno.Text.Trim();
                    trab.direccion = txtDireccion.Text.Trim();
                    trab.telefono = txtTelefono.Text.Trim();
                    trab.email = txtEmail.Text.Trim();
                    trab.fechaCreacion = new DateTime();
                    trab.fechaModificacion = new DateTime();
                    trab.isActivo = cbxActivo.Checked ? (short)1 : (short)0;
                    trab.idCiudad = long.Parse(cbxCiudad.SelectedValue.ToString());
                    trab.idTrabajador = this.trabajadorSeleccionado.idTrabajador;

                    usuarioDAO.editarUsuarioTrabajador(usuarioNuevo, trab);

                    MessageBox.Show("Usuario editado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ha ocurrido un error grave editando Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
