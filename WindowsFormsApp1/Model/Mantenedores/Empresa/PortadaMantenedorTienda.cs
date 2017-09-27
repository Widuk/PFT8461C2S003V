﻿using System;
using System.Drawing;
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
            objetoPaso.limpiaPaso();
            cargaTiendas();
            tiendaToolStripMenuItem.ForeColor = Color.Gray;
        }

        public void cargaTiendas()
        {
            TiendaDAO listarTiendas = new TiendaDAO();
            dtgTiendas.DataSource = listarTiendas.listarTiendas();

            dtgTiendas.Columns[0].HeaderText = "N°";
            dtgTiendas.Columns[1].HeaderText = "Nombre";
            dtgTiendas.Columns[2].HeaderText = "Dirección";
            dtgTiendas.Columns[3].HeaderText = "Ciudad";
            dtgTiendas.Columns[4].HeaderText = "Telefono";
            dtgTiendas.Columns[5].HeaderText = "activo";
            dtgTiendas.Columns[5].Visible = false;
            dtgTiendas.Columns[6].HeaderText = "F. Creación";
            dtgTiendas.Columns[7].HeaderText = "F. Modificación";
            dtgTiendas.Columns[8].HeaderText = "Empresa";
            dtgTiendas.Columns[9].HeaderText = "IdCiudad";
            dtgTiendas.Columns[9].Visible = false;
            dtgTiendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            objetoPaso.paso3 = filaSeleccionada.Cells[3].Value.ToString();  //ciudad
            objetoPaso.paso4 = filaSeleccionada.Cells[4].Value.ToString();  //telefono
            objetoPaso.paso5 = filaSeleccionada.Cells[5].Value.ToString();  //activo
            objetoPaso.paso6 = filaSeleccionada.Cells[6].Value.ToString();  //creacion
            objetoPaso.paso7 = filaSeleccionada.Cells[7].Value.ToString();  //modificacion
            objetoPaso.paso8 = filaSeleccionada.Cells[8].Value.ToString();  //empresa
            objetoPaso.paso9 = filaSeleccionada.Cells[9].Value.ToString();  //idCiudad
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargaTiendas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (objetoPaso.paso0 == null || objetoPaso.paso0 == "0" || objetoPaso.paso0 == "")
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
                MessageBox.Show("Éxito al eliminar tienda.");
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

        private void dtgTiendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }
    }
}