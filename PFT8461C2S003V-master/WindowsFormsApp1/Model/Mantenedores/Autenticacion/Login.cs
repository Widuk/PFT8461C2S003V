using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.OfertasWS;
using WindowsFormsApp1.Model.Home;
using WindowsFormsApp1.Model.Negocio.Conexion;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1.Model.Autenticacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == null || txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: El login de Usuario es Obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Focus();
                } else if (txtContrasena.Text == null || txtUsuario.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Error: La Contraseña Obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtContrasena.Focus();
                }else
                {
                    loginRequestVO loginRequestVO = new loginRequestVO();
                    loginRequestVO.password = txtContrasena.Text;
                    loginRequestVO.username = txtUsuario.Text;
                    OfertasWSClient ofertaWS = new OfertasWSClient();
                    loginResponseVO loginResponse = ofertaWS.procesarLogin(loginRequestVO);

                    if (loginResponse.codigoRespuesta == 0)
                    {
                        UsuarioDAO usuarioDAO = new UsuarioDAO();
                        ConsumidorDAO consumidorDAO = new ConsumidorDAO();
                        FuncionalidadDAO funcionalidadDAO = new FuncionalidadDAO();

                        Usuario usu = usuarioDAO.getUsuarioPorCodigo(loginResponse.codigoUsuario);

                        if(usu.isActivo == 0)
                        {
                            MessageBox.Show("Error: El usuario ingresado se encuentra inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Consumidor cons = consumidorDAO.getConsumidorPorCodigoUsuario(usu.idUsuario);

                        if(cons != null)
                        {
                            MessageBox.Show("Error: El usuario ingresado pertenece a un Consumidor, no es posible ingresar a la aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                     
                        List<Funcionalidad> funcionalidadesUsuario = funcionalidadDAO.getFuncionalidadesPorPerfil(usu.codigoPerfil);
                        usu.funcionalidadesUsuario = funcionalidadesUsuario;
                        SesionBag.usuarioSesionado = usu;
                        objetoPaso.pasoUsuario = txtUsuario.Text;
                        Index homeView = new Index();
                        homeView.Visible = true;
                        this.Visible = false;
                    }
                    else {
                        MessageBox.Show(loginResponse.respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave procesando Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
