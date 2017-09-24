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
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.Usuario
{
    public partial class ListarUsuarios : Form
    {
        private BindingList<UsuarioGridVO> listaUsuarios;
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                List<UsuarioGridVO> listaUsuariosFin = new List<UsuarioGridVO>();
                listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosTrabajadores());
                //listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosConsumidores());
                
                listaUsuarios =  new BindingList<UsuarioGridVO>(listaUsuariosFin);

                this.dgvUsuario.DataSource = listaUsuarios;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave listando Usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvUsuario.Columns[0].HeaderText = "N°";
            this.dgvUsuario.Columns[1].HeaderText = "Login";
            this.dgvUsuario.Columns[2].HeaderText = "Estado";
            this.dgvUsuario.Columns[3].HeaderText = "Fecha Creación";
            this.dgvUsuario.Columns[4].HeaderText = "Fecha Modificación";
            this.dgvUsuario.Columns[5].HeaderText = "Nombre";
            this.dgvUsuario.Columns[6].HeaderText = "Apellido Paterno";
            this.dgvUsuario.Columns[7].HeaderText = "Apellido Materno";
            this.dgvUsuario.Columns[8].HeaderText = "Rut";
            this.dgvUsuario.Columns[9].HeaderText = "Tipo Usuario";
            this.dgvUsuario.Columns[10].HeaderText = "Perfil";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                List<UsuarioGridVO> listaUsuariosFin = new List<UsuarioGridVO>();
                listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosTrabajadores());
                listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosConsumidores());

                listaUsuarios = new BindingList<UsuarioGridVO>(listaUsuariosFin);

                this.dgvUsuario.DataSource = listaUsuarios;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.ShowDialog();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<UsuarioGridVO> listaUsuariosFin = new List<UsuarioGridVO>();
            listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosTrabajadores());
            listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosConsumidores());

            listaUsuarios = new BindingList<UsuarioGridVO>(listaUsuariosFin);

            this.dgvUsuario.DataSource = listaUsuarios;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("descuentosToolStripMenuItem"))
            {
                ListarDescuentos listarDesc = new ListarDescuentos();
                listarDesc.Show();
                this.Hide();
                //this.Dispose();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvUsuario.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar un usuario para Editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UsuarioDAO usuarioDAO = new UsuarioDAO();
                    TrabajadorDAO trabajadorDAO = new TrabajadorDAO();

                    WindowsFormsApp1.Model.Negocio.Entities.Usuario usuarioSeleccionado = usuarioDAO.getUsuarioPorCodigo(long.Parse(dgvUsuario.SelectedRows[0].Cells[0].Value.ToString()));
                    Trabajador trabajadorSeleccionado = trabajadorDAO.getTrabajadorPorIdUsuario(usuarioSeleccionado.idUsuario);
                    EditarUsuario editarUsuario = new EditarUsuario();
                    editarUsuario.usuarioSeleccionado = usuarioSeleccionado;
                    editarUsuario.trabajadorSeleccionado = trabajadorSeleccionado;
                    editarUsuario.ShowDialog();

                    List<UsuarioGridVO> listaUsuariosFin = new List<UsuarioGridVO>();
                    listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosTrabajadores());
                    listaUsuariosFin.AddRange(usuarioDAO.getListaUsuariosConsumidores());

                    listaUsuarios = new BindingList<UsuarioGridVO>(listaUsuariosFin);

                    this.dgvUsuario.DataSource = listaUsuarios;

                    this.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave editando usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
