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
using WindowsFormsApp1.Model.Mantenedores.Usuario;
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
            try
            {
                OfertaDAO ofertaDAO = new OfertaDAO();
                listaOfertas = new BindingList<OfertaGridVO>(ofertaDAO.getListaOfertasGrid());
                this.dgvOferta.DataSource = listaOfertas;
                ofertasToolStripMenuItem.ForeColor = Color.Gray;

            }catch(Exception ex)
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
    }
}
