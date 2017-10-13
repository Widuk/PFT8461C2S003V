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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                PerfilDAO perfilDAO = new PerfilDAO();
                DataTable dt = perfilDAO.getPerfilesCbx();
                this.cbxPerfil.DataSource = dt;
                this.cbxPerfil.DisplayMember = "NOMBRE";
                this.cbxPerfil.ValueMember = "IDPERFIL";
            }catch(Exception ex){
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: Ha ocurrido un error grave cargando Ciudades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones varias
                if (txtNombre.Text == null || txtNombre.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                } else if (txtApellidoPaterno.Text == null || txtApellidoPaterno.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Apellido Paterno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApellidoPaterno.Focus();
                    return;
                } else if (txtApellidoMaterno.Text == null || txtApellidoMaterno.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Apellido Materno es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtApellidoMaterno.Focus();
                    return;
                } else if (txtRut.Text == null || txtRut.Text.Trim().Equals(string.Empty)) {
                    MessageBox.Show("Error: El Rut es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRut.Focus();
                    return;
                } else if (txtDireccion.Text == null || txtDireccion.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La Dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDireccion.Focus();
                    return;
                } else if (txtTelefono.Text == null || txtTelefono.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefono.Focus();
                    return;
                } else if (txtLogin.Text == null || txtLogin.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Login es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                    return;
                } else if (txtEmail.Text == null || txtEmail.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El Email es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                } else if (txtContrasena.Text == null || txtContrasena.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La Contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    return;
                } else if (txtContrasena2.Text == null || txtContrasena2.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La confirmación de Contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena2.Focus();
                    return;
                } else if (!Utils.ValidaRut(txtRut.Text.Trim()))
                {
                    MessageBox.Show("Error: El Rut ingresado no es válido. Debe ser sin puntos y con guión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRut.Focus();
                    return;
                } else if (!Utils.IsValidEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Error: El Email ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    UsuarioDAO usuarioDAO = new UsuarioDAO();
                    WindowsFormsApp1.Model.Negocio.Entities.Usuario usu = usuarioDAO.getUsuarioPorLogin(txtLogin.Text.Trim().ToUpper());
                    if (usu != null)
                    {
                        MessageBox.Show("Error: El Login ingresado ya se encuentra utilizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Text = "";
                        txtLogin.Focus();
                        return;
                    }

                    if (!txtContrasena.Text.Trim().Equals(txtContrasena2.Text.Trim()))
                    {
                        MessageBox.Show("Error: Las Contraseñas ingresadas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Text = "";
                        txtContrasena2.Text = "";
                        txtContrasena.Focus();
                        return;
                    }

                    //Creación de nuevo usuario
                    WindowsFormsApp1.Model.Negocio.Entities.Usuario usuarioNuevo = new WindowsFormsApp1.Model.Negocio.Entities.Usuario();
                    usuarioNuevo.login = txtLogin.Text.Trim().ToUpper();
                    usuarioNuevo.password = Utils.EncodePassword(txtContrasena.Text.Trim());
                    usuarioNuevo.isActivo = short.Parse("1");
                    usuarioNuevo.fechaCreacion = new DateTime();
                    usuarioNuevo.fechaModificacion = new DateTime();
                    usuarioNuevo.idSession = string.Empty;
                    usuarioNuevo.codigoPerfil = long.Parse(cbxPerfil.SelectedValue.ToString());

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
                    trab.isActivo = short.Parse("1");
                    trab.idCiudad = long.Parse(cbxCiudad.SelectedValue.ToString());

                    usuarioDAO.crearUsuarioTrabajador(usuarioNuevo, trab);

                    MessageBox.Show("Usuario creado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: Ha ocurrido un error grave creando Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
