using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Investigacion.Reportes;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Mantenedores.Valoracion;

namespace WindowsFormsApp1
{
    public partial class PortadaMantenedorProducto : Form
    {
        public PortadaMantenedorProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuarioIngreso.Text = "Bienvenido(a): " + objetoPaso.pasoUsuario;
            objetoPaso.limpiaPaso();
            cargaProductos();
            ProductoDAO listaProductos = new ProductoDAO();
            int cuentaTiendas = listaProductos.listarProducto().Count;
            if (cuentaTiendas == 0)
            {
                MessageBox.Show("No se econtraron productos para listar.");
            }

            foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                itm.Click += new EventHandler(genericHandler);
                itm.Name = func.idFuncionalidad.ToString();
                if (itm.Name.Equals("2"))
                {
                    itm.ForeColor = Color.Gray;
                }
                this.menuStrip1.Items.Add(itm);
            }

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
            dtgListaPreducto.Columns[8].HeaderText = "Fecha de Creación";
            dtgListaPreducto.Columns[9].HeaderText = "Fecha de Modificación";
            dtgListaPreducto.Columns[10].HeaderText = "Tienda";
            dtgListaPreducto.Columns[10].Visible = false;
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
                    CrearProducto cp = new CrearProducto();                    
                    cp.ShowDialog();
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
            try
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
                                                                                //objetoPaso.paso10 = filaSeleccionada.Cells[10].Value.ToString();//Tienda
                                                                                //objetoPaso.paso11 = filaSeleccionada.Cells[12].Value.ToString();//IDTIENDA
                objetoPaso.paso12 = filaSeleccionada.Cells[13].Value.ToString();//IDRubro
                                                                                //objetoPaso.paso10 = filaSeleccionada.Cells[14].Value.ToString();//Rubro
            }
            catch (Exception)
            {
                return;
            }
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

        private void genericHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem.Name.Equals("1"))
            {
                PortadaMantenedorTienda mantTienda = new PortadaMantenedorTienda();
                mantTienda.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("4"))
            {
                ListarDescuentos listarDesc = new ListarDescuentos();
                listarDesc.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("5"))
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
            else if (clickedItem.Name.Equals("12"))
            {
                ResumenPorTienda rpt = new ResumenPorTienda();
                rpt.Show();
                this.Hide();
            }
        }

        private void dtgListaPreducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
