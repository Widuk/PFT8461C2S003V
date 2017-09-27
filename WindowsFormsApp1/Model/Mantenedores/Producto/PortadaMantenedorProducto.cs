﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;

namespace WindowsFormsApp1
{
    public partial class PortadaMantenedorProducto : Form
    {
        public PortadaMantenedorProducto()
        {
            InitializeComponent();
            productosToolStripMenuItem.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objetoPaso.limpiaPaso();
            cargaProductos();
        }

        public void cargaProductos()
        {
            ProductoDAO listaProductos = new ProductoDAO();
            dtgListaPreducto.DataSource = listaProductos.listarProducto();

            dtgListaPreducto.Columns[0].HeaderText = "N°";
            dtgListaPreducto.Columns[1].HeaderText = "Nombre";
            dtgListaPreducto.Columns[2].HeaderText = "Descripción";
            dtgListaPreducto.Columns[3].HeaderText = "Precio";
            dtgListaPreducto.Columns[4].HeaderText = "2X1";
            dtgListaPreducto.Columns[5].Visible = false;    //id2X1
            dtgListaPreducto.Columns[6].HeaderText = "SKU";
            dtgListaPreducto.Columns[7].Visible = false;    //isactivo
            dtgListaPreducto.Columns[8].HeaderText = "F.Creación";
            dtgListaPreducto.Columns[9].HeaderText = "F.Modificación";
            dtgListaPreducto.Columns[10].HeaderText = "Tienda";
            dtgListaPreducto.Columns[11].HeaderText = "Rubro";
            dtgListaPreducto.Columns[12].Visible = false;
            dtgListaPreducto.Columns[13].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TiendaDAO listaTiendas = new TiendaDAO();
            int x = listaTiendas.listarTiendas().Count;
            RubroDAO listaRubros = new RubroDAO();
            int j = listaTiendas.listarTiendas().Count;
            if (x > 0)
            {
                if (j > 0) {
                    CrearProducto ct = new CrearProducto();
                    ct.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se econtraron rubros para asociar un producto.");
                    return;
                }
             }
            else
            {
                MessageBox.Show("Debe haber al menos una tienda para ingresar un producto.");
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargaProductos();
        }

        public void dtgListaPreducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow filaSeleccionada = dtgListaPreducto.Rows[index];
            objetoPaso.paso0 = filaSeleccionada.Cells[0].Value.ToString();  //id
            objetoPaso.paso1 = filaSeleccionada.Cells[1].Value.ToString();  //producto
            objetoPaso.paso2 = filaSeleccionada.Cells[2].Value.ToString();  //descripción
            objetoPaso.paso3 = filaSeleccionada.Cells[3].Value.ToString();  //precio
            objetoPaso.paso4 = filaSeleccionada.Cells[4].Value.ToString();  //2X1
            objetoPaso.paso5 = filaSeleccionada.Cells[5].Value.ToString();  //is2X1
            objetoPaso.paso6 = filaSeleccionada.Cells[6].Value.ToString();  //SKU
            objetoPaso.paso7 = filaSeleccionada.Cells[7].Value.ToString();  //isactivo
            objetoPaso.paso8 = filaSeleccionada.Cells[8].Value.ToString();  //fechaCreacion
            objetoPaso.paso9 = filaSeleccionada.Cells[9].Value.ToString();  //FechaModificacion
            objetoPaso.paso10 = filaSeleccionada.Cells[10].Value.ToString();//Tienda
            objetoPaso.paso11 = filaSeleccionada.Cells[12].Value.ToString();//IDTIENDA
            objetoPaso.paso12 = filaSeleccionada.Cells[13].Value.ToString();//IDRubro
            //objetoPaso.paso10 = filaSeleccionada.Cells[14].Value.ToString();//Rubro
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (objetoPaso.paso0 == null || objetoPaso.paso0 == "0" || objetoPaso.paso0 == "")
            {
                return;
            }
            EditarProducto productoEdit = new EditarProducto();
            productoEdit.ShowDialog();
        }

        private void btnEliminarDescuento_Click(object sender, EventArgs e)
        {
            if (objetoPaso.paso0 == null)
            {
                return;
            }
            try
            {
                ProductoDAO eliminaProducto = new ProductoDAO();
                Int16 id = Int16.Parse(objetoPaso.paso0);
                eliminaProducto.EliminarProducto(id);
                MessageBox.Show("Éxito al eliminar producto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("usuariosToolStripMenuItem"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("tiendasToolStripMenuItem"))
            {
                PortadaMantenedorTienda mantTienda = new PortadaMantenedorTienda();
                mantTienda.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("descuentosToolStripMenuItem"))
            {
                ListarDescuentos mantDesc = new ListarDescuentos();
                mantDesc.Show();
                this.Hide();
            }
        }

        private void dtgListaPreducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }
    }
}
