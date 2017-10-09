using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.Descuento
{
    public partial class ListarDescuentos : Form
    {
        private BindingList<DescuentoGridVO> listaDescuentos;
        public ListarDescuentos()
        {
            InitializeComponent();
        }

        private void ListarDescuentos_Load(object sender, EventArgs e)
        {
            DescuentoDAO descDAO = new DescuentoDAO();
            listaDescuentos = new BindingList<DescuentoGridVO>(descDAO.getAllDescuentosGrid());
            this.dgvDescuento.DataSource = listaDescuentos;
            descuentosToolStripMenuItem.ForeColor = Color.Gray;
        }

        private void dgvDescuento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvDescuento.Columns[0].HeaderText = "N°";
            this.dgvDescuento.Columns[1].HeaderText = "Nombre";
            this.dgvDescuento.Columns[2].HeaderText = "Descripción";
            this.dgvDescuento.Columns[3].HeaderText = "Es % Desc";
            this.dgvDescuento.Columns[4].HeaderText = "% Desc";
            this.dgvDescuento.Columns[5].HeaderText = "Es $ Desc";
            this.dgvDescuento.Columns[6].HeaderText = "Precio Desc";
            this.dgvDescuento.Columns[7].HeaderText = "SKU Producto";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CrearDescuento cdescuento = new CrearDescuento();
            cdescuento.ShowDialog();
            DescuentoDAO descDAO = new DescuentoDAO();
            listaDescuentos = new BindingList<DescuentoGridVO>(descDAO.getAllDescuentosGrid());
            this.dgvDescuento.DataSource = listaDescuentos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DescuentoDAO descDAO = new DescuentoDAO();
            listaDescuentos = new BindingList<DescuentoGridVO>(descDAO.getAllDescuentosGrid());
            this.dgvDescuento.DataSource = listaDescuentos;
        }

        private void btnEliminarDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvDescuento.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar un descuento para Eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar " + dgvDescuento.SelectedRows[0].Cells[2].Value.ToString() + "?", "Eliminar " + dgvDescuento.SelectedRows[0].Cells[2].Value.ToString(), MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        long codigoDescuento = long.Parse(dgvDescuento.SelectedRows[0].Cells[0].Value.ToString());
                        DescuentoDAO descuentoDAO = new DescuentoDAO();
                        descuentoDAO.eliminarDescuentoPorId(codigoDescuento);
                        listaDescuentos = new BindingList<DescuentoGridVO>(descuentoDAO.getAllDescuentosGrid());
                        this.dgvDescuento.DataSource = listaDescuentos;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error grave eliminando Descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDescuento.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar un descuento para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OfertaDAO ofertaDAO = new OfertaDAO();
                    DescuentoDAO descuentoDAO = new DescuentoDAO();
                    WindowsFormsApp1.Model.Negocio.Entities.Descuento descuentoSeleccionado = descuentoDAO.obtenerDescuentoPorID(long.Parse(dgvDescuento.SelectedRows[0].Cells[0].Value.ToString()));
                    Oferta oferta = ofertaDAO.getOfertaVigenteByCodigoProducto(descuentoSeleccionado.idProducto);

                    if(oferta != null)
                    {
                        MessageBox.Show("Error: Existe una oferta activa para este descuento, no puede ser editado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ModificarDescuento modif = new ModificarDescuento();
                    modif.descuentoSeleccionado = descuentoSeleccionado;
                    modif.ShowDialog();
                    listaDescuentos = new BindingList<DescuentoGridVO>(descuentoDAO.getAllDescuentosGrid());
                    this.dgvDescuento.DataSource = listaDescuentos;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error grave editando Descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("usuariosToolStripMenuItem"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
                //this.Dispose();
            }else if (e.ClickedItem.Name.Equals("tiendasToolStripMenuItem"))
            {
                PortadaMantenedorTienda mantTienda = new PortadaMantenedorTienda();
                mantTienda.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("productosToolStripMenuItem"))
            {
                PortadaMantenedorProducto mantProd = new PortadaMantenedorProducto();
                mantProd.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("biToolStripMenuItem"))
            {
                ArchivosBI mantBI = new ArchivosBI();
                mantBI.Show();
                this.Hide();
            }
        }
    }
}
