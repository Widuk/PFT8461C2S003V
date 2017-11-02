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
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Mantenedores.Valoracion;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.Oferta
{
    public partial class ListarOfertas : Form
    {
        private BindingList<OfertaGridVO> listaOfertas;
        public ListarOfertas()
        {
            InitializeComponent();
        }

        private void ListarOfertas_Load(object sender, EventArgs e)
        {
            lblUsuarioIngreso.Text = "Bienvenido(a): " + objetoPaso.pasoUsuario;
            try
            {
                OfertaDAO ofertaDAO = new OfertaDAO();
                listaOfertas = new BindingList<OfertaGridVO>(ofertaDAO.getListaOfertasGrid());
                this.dgvOferta.DataSource = listaOfertas;

                foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
                {
                    ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                    itm.Click += new EventHandler(genericHandler);
                    itm.Name = func.idFuncionalidad.ToString();
                    if (itm.Name.Equals("6"))
                    {
                        itm.ForeColor = Color.Gray;
                    }
                    this.menuStrip1.Items.Add(itm);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave listando Ofertas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOferta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                this.dgvOferta.Columns[0].HeaderText = "N°";
                this.dgvOferta.Columns[1].HeaderText = "F.Inicio";
                this.dgvOferta.Columns[2].HeaderText = "F.Fin";
                this.dgvOferta.Columns[3].HeaderText = "N° Productos Min.";
                this.dgvOferta.Columns[4].HeaderText = "N° Pruductos Max.";
                this.dgvOferta.Columns[5].HeaderText = "Estado";
                this.dgvOferta.Columns[6].HeaderText = "Producto";
                this.dgvOferta.Columns[7].HeaderText = "SKU Producto";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave listando Ofertas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("descuentosToolStripMenuItem"))
            {
                ListarDescuentos listarDesc = new ListarDescuentos();
                listarDesc.Show();
                this.Hide();
                //this.Dispose();
            }
            else if (e.ClickedItem.Name.Equals("usuariosToolStripMenuItem"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
                //this.Dispose()
            }
            else if (e.ClickedItem.Name.Equals("productosToolStripMenuItem"))
            {
                PortadaMantenedorProducto mantProd = new PortadaMantenedorProducto();
                mantProd.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("descuentosToolStripMenuItem"))
            {
                ListarDescuentos listarDescuentos = new ListarDescuentos();
                listarDescuentos.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("biToolStripMenuItem"))
            {
                ArchivosBI mantBI = new ArchivosBI();
                mantBI.Show();
                this.Hide();
            }
        }

        private void genericHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem.Name.Equals("1"))
            {
                PortadaMantenedorTienda mantTienda = new PortadaMantenedorTienda();
                mantTienda.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("2"))
            {
                PortadaMantenedorProducto mantProd = new PortadaMantenedorProducto();
                mantProd.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("4"))
            {
                ListarDescuentos listarDesc = new ListarDescuentos();
                listarDesc.Show();
                this.Hide();
            }
            if (clickedItem.Name.Equals("5"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("6"))
            {
                ListarOfertas listarOfertas = new ListarOfertas();
                listarOfertas.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("10"))
            {
                ArchivosBI mantBI = new ArchivosBI();
                mantBI.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("11"))
            {
                ConsultaValoracion consultaValoracion = new ConsultaValoracion();
                consultaValoracion.Show();
                this.Hide();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OfertaDAO ofertaDAO = new OfertaDAO();
                listaOfertas = new BindingList<OfertaGridVO>(ofertaDAO.getListaOfertasGrid());
                this.dgvOferta.DataSource = listaOfertas;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error grave listando Ofertas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearOferta crearOferta = new CrearOferta();
            crearOferta.ShowDialog();
            OfertaDAO ofertaDAO = new OfertaDAO();
            listaOfertas = new BindingList<OfertaGridVO>(ofertaDAO.getListaOfertasGrid());
            this.dgvOferta.DataSource = listaOfertas;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOferta.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar una oferta para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OfertaDAO ofertaDAO = new OfertaDAO();
                    WindowsFormsApp1.Model.Negocio.Entities.Oferta oferta = ofertaDAO.getOfertaByCodigo(long.Parse(this.dgvOferta.SelectedRows[0].Cells[0].Value.ToString()));

                    EditarOferta modif = new EditarOferta();
                    modif.ofertaSeleccionada = oferta;
                    modif.ShowDialog();
                    listaOfertas = new BindingList<OfertaGridVO>(ofertaDAO.getListaOfertasGrid());
                    this.dgvOferta.DataSource = listaOfertas;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error grave editando Oferta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOferta.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar una oferta a publicar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OfertaDAO ofertaDao = new OfertaDAO();
                    WindowsFormsApp1.Model.Negocio.Entities.Oferta oferta = ofertaDao.getOfertaByCodigo(long.Parse(this.dgvOferta.SelectedRows[0].Cells[0].Value.ToString()));
                    if (oferta.isPublicada.Equals(1))
                    {
                        MessageBox.Show("La oferta ya se encuentra publicada.");
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro que desea publicar la oferta seleccionada?", "Publicar " + oferta, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            ofertaDao.publicarOferta(oferta.idOferta);
                            MessageBox.Show("Oferta publicada exitosamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error grave publicando oferta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
