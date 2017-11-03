using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.Valoracion
{
    public partial class ConsultaValoracion : Form
    {
        public ConsultaValoracion()
        {
            InitializeComponent();
        }

        private void ConsultaValoracion_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuarioIngreso.Text = "Bienvenido(a): " + objetoPaso.pasoUsuario;
                this.cargaTiendas();
                foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
                {
                    ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                    itm.Click += new EventHandler(genericHandler);
                    itm.Name = func.idFuncionalidad.ToString();
                    if (itm.Name.Equals("11"))
                    {
                        itm.ForeColor = Color.Gray;
                    }
                    this.menuStrip1.Items.Add(itm);
                }
            }
            catch(Exception ex)
            {

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
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgTiendas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Error: Debe seleccionar una tienda para generar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    ValoracionDAO valoracionDAO = new ValoracionDAO();
                    List<ReporteValoracionVO> listaReporteValoracion = valoracionDAO.getValoracionesTienda(long.Parse(this.dtgTiendas.SelectedRows[0].Cells[0].Value.ToString()));
                    if(listaReporteValoracion.Count == 0)
                    {
                        MessageBox.Show("La Tienda seleccionada no tiene valoraciones asociadas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SaveFileDialog guardarExcel = new SaveFileDialog();
                        guardarExcel.Filter = "Excel File|*.xls";
                        guardarExcel.Title = "Guardar Reporte";
                        guardarExcel.ShowDialog();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave generando reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
