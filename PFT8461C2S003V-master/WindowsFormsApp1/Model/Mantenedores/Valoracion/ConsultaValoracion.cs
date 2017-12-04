using System;
using System.Collections.Generic;
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
using WindowsFormsApp1.Model.Negocio.Vo;
using Microsoft.Office.Interop.Excel;

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
                ListarDescuentos listarUsu = new ListarDescuentos();
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
            else if (clickedItem.Name.Equals("5"))
            {
                ListarUsuarios listarUsuarios = new ListarUsuarios();
                listarUsuarios.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("12"))
            {
                ResumenPorTienda rpt = new ResumenPorTienda();
                rpt.Show();
                this.Hide();
            }
        }

        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            Close();
            //Microsoft.Office.Interop.Excel.Application.Exit();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)excel.ActiveSheet;

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
                        ws.Cells[1, 1] = "Nombre Producto";
                        ws.Cells[1, 1].Interior.Color = Color.Orange;
                        ws.Cells[1, 2] = "Código producto";
                        ws.Cells[1, 2].Interior.Color = Color.Orange;
                        ws.Cells[1, 3] = "Precio";
                        ws.Cells[1, 3].Interior.Color = Color.Orange;
                        ws.Cells[1, 4] = "Rut Consumior";
                        ws.Cells[1, 4].Interior.Color = Color.Orange;
                        ws.Cells[1, 5] = "Nombre consumidor";
                        ws.Cells[1, 5].Interior.Color = Color.Orange;
                        ws.Cells[1, 6] = "Fecha Inicio Oferta";
                        ws.Cells[1, 6].Interior.Color = Color.Orange;
                        ws.Cells[1, 7] = "Fecha fin Oferta";
                        ws.Cells[1, 7].Interior.Color = Color.Orange;
                        ws.Cells[1, 8] = "Fecha valoración";
                        ws.Cells[1, 8].Interior.Color = Color.Orange;
                        ws.Cells[1, 9] = "Nota valoración";
                        ws.Cells[1, 9].Interior.Color = Color.Orange;
                        ws.Cells[1, 10] = "Detalle valoración";
                        ws.Cells[1, 10].Interior.Color = Color.Orange;

                        for (int f = 1; f < listaReporteValoracion.Count + 1; f++)
                        {
                            for (int j = 0; j < listaReporteValoracion.Count; j++)
                            {
                                ws.Cells[f+1, j+1] = listaReporteValoracion[f-1].nombreProducto;
                                ws.Cells[f+1, j+2] = listaReporteValoracion[f-1].codigoProducto;
                                ws.Cells[f+1, j+3] = listaReporteValoracion[f-1].precioProducto;
                                ws.Cells[f+1, j+4] = listaReporteValoracion[f-1].rutConsumidor;
                                ws.Cells[f+1, j+5] = listaReporteValoracion[f-1].nombreConsumidor;
                                ws.Cells[f+1, j+6] = listaReporteValoracion[f-1].fechaInicioOferta;
                                ws.Cells[f+1, j+7] = listaReporteValoracion[f-1].fechaTerminoOferta;
                                ws.Cells[f+1, j+8] = listaReporteValoracion[f-1].fechaValoracion;
                                ws.Cells[f+1, j+9] = listaReporteValoracion[f-1].notaValoracion;
                                ws.Cells[f+1, j+10] = listaReporteValoracion[f-1].detalleValoracion;
                            }
                        }
    
                        SaveFileDialog guardarExcel = new SaveFileDialog();
                        guardarExcel.FileName = "Informe valoracion";
                        guardarExcel.DefaultExt = "*.xlsx";
                        //guardarExcel.Filter = "Excel File|*.xlsx";
                        guardarExcel.Filter = "Archivos de Excel (*.xlsx)|*.xlsx ";
                        guardarExcel.Title = "Guardar Reporte";
                        guardarExcel.ShowDialog();
                        ws.SaveAs(guardarExcel.FileName);

                        guardarExcel = null;
                        ws = null;
                        excel.Quit();
                        MessageBox.Show("El archivo fue descargado con éxito.");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error grave generando reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaValoracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
