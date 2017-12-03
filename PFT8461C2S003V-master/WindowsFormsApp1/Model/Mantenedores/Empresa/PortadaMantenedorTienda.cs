using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Investigacion.Reportes;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Mantenedores.Valoracion;

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
            lblUsuarioIngreso.Text = "Bienvenido(a): " + objetoPaso.pasoUsuario;
            objetoPaso.limpiaPaso();
            cargaTiendas();

            foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                itm.Click += new EventHandler(genericHandler);
                itm.Name = func.idFuncionalidad.ToString();
                if (itm.Name.Equals("1"))
                {
                    itm.ForeColor = Color.Gray;
                }
                this.menuStrip1.Items.Add(itm);
            }
        }

        public void cargaTiendas()
        {
            try
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
                dtgTiendas.Columns[6].HeaderText = "Fecha de Creación";
                dtgTiendas.Columns[7].HeaderText = "Fecha de Modificación";
                dtgTiendas.Columns[8].HeaderText = "Empresa";
                dtgTiendas.Columns[9].HeaderText = "IdCiudad";
                dtgTiendas.Columns[9].Visible = false;
                dtgTiendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema al cargar tiendas.");
            }
        }


        private void btnNuevaTienda_Click(object sender, EventArgs e)
        {
            CrearTienda ct = new CrearTienda();
            ct.ShowDialog();
        }

        private void dtgTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception )
            {
                return;
            }
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
                if (EliminaTienda.buscaTiendaNoAsociada(int.Parse(objetoPaso.paso0)))
                {
                    MessageBox.Show("La tienda está asociada a un producto, por lo cual no se puede eliminar.");
                    return;
                }                   
                Int16 id = Int16.Parse(objetoPaso.paso0);
                EliminaTienda.EliminarTienda(id);
                MessageBox.Show("Éxito al eliminar tienda.");
                cargaTiendas();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar tienda.");
            }
        }

        private void genericHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem.Name.Equals("2"))
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

        private void dtgTiendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void dtgTiendas_DoubleClick(object sender, EventArgs e)
        {
            return;
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void PortadaMantenedorTienda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
