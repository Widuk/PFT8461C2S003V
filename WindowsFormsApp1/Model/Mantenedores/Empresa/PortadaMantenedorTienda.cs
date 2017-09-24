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
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    public partial class PortadaMantenedorTienda : Form
    {
        public PortadaMantenedorTienda()
        {
            InitializeComponent();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            cargaTiendas();
        }

        public void cargaTiendas()
        {
            TiendaDAO listarTiendas = new TiendaDAO();
            dtgTiendas.DataSource = listarTiendas.listarTiendas();

            dtgTiendas.Columns[0].HeaderText = "N°";
            dtgTiendas.Columns[1].HeaderText = "Nombre";
            dtgTiendas.Columns[2].HeaderText = "Dirección";
            dtgTiendas.Columns[3].HeaderText = "telefono";
            dtgTiendas.Columns[4].HeaderText = "activo";
            dtgTiendas.Columns[4].Visible = false;
            dtgTiendas.Columns[5].HeaderText = "F. Creación";
            dtgTiendas.Columns[6].HeaderText = "F. Modificación";
            dtgTiendas.Columns[7].HeaderText = "Empresa";
            dtgTiendas.Columns[8].HeaderText = "Ciudad";
        }


        private void btnNuevaTienda_Click(object sender, EventArgs e)
        {
            CrearTienda ct = new CrearTienda();
            ct.ShowDialog();
        }

        private void dtgTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow filaSeleccionada = dtgTiendas.Rows[index];
            objetoPaso.paso0 = filaSeleccionada.Cells[0].Value.ToString();  //id
            objetoPaso.paso1 = filaSeleccionada.Cells[1].Value.ToString();  //nombre
            objetoPaso.paso2 = filaSeleccionada.Cells[2].Value.ToString();  //dirección
            objetoPaso.paso3 = filaSeleccionada.Cells[3].Value.ToString();  //telefono
            objetoPaso.paso4 = filaSeleccionada.Cells[4].Value.ToString();  //activo
            objetoPaso.paso5 = filaSeleccionada.Cells[5].Value.ToString();  //creacion
            objetoPaso.paso6 = filaSeleccionada.Cells[6].Value.ToString();  //modificacion
            objetoPaso.paso7 = filaSeleccionada.Cells[7].Value.ToString();  //Empresa
            objetoPaso.paso8 = filaSeleccionada.Cells[8].Value.ToString();  //Ciudad
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargaTiendas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (objetoPaso.paso0 == null)
            {
                return;
            }
            EditarTiendas tiendaEdit = new EditarTiendas();
            tiendaEdit.ShowDialog();
        }

        private void btnEliminarDescuento_Click(object sender, EventArgs e)
        {
            if (objetoPaso.paso0 == null)
            {
                return;
            }
            try
            {
                TiendaDAO EliminaTienda = new TiendaDAO();
                Int16 id = Int16.Parse(objetoPaso.paso0);
                EliminaTienda.EliminarTienda(id);
                MessageBox.Show("Éxito al eliminar producto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar tienda.");
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortadaMantenedorProducto j = new PortadaMantenedorProducto();
            j.Visible = true;
            this.Close();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarDescuentos j = new ListarDescuentos();
            j.Visible = true;
            this.Close();
        }

        private void asdadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            else if (e.ClickedItem.Name.Equals("usuariosToolStripMenuItem"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
                //this.Dispose()
            }else if (e.ClickedItem.Name.Equals("productosToolStripMenuItem"))
            {
                PortadaMantenedorProducto mantProd = new PortadaMantenedorProducto();
                mantProd.Show();
                this.Hide();
            }
        }
    }
}
