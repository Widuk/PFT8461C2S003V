using System;
using System.Drawing;
using WindowsFormsApp1.Controler.DAO;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using System.Collections.Generic;
using WindowsFormsApp1.Model.Negocio.Vo;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.IO;
using WindowsFormsApp1.Model.Mantenedores.Valoracion;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using System.Drawing;

namespace WindowsFormsApp1.Model.Investigacion.Reportes
{
    public partial class ResumenPorTienda : Form
    {

        public ResumenPorTienda()
        {
            InitializeComponent();
        }

        private void ResumenPorTienda_Load(object sender, EventArgs e)
        {
            cargarTiendas();
            foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                itm.Click += new EventHandler(genericHandler);
                itm.Name = func.idFuncionalidad.ToString();
                if (itm.Name.Equals("12"))
                {
                    itm.ForeColor = Color.Gray;
                }
                this.menuStrip1.Items.Add(itm);
            }
        }

        private void btnDescargaResumen_Click(object sender, EventArgs e)
        {
            if (cmbTiendaBI.SelectedIndex == -1 )
            {
                MessageBox.Show("Debe seleccionar una tienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTiendaBI.Focus();
                return;
            }

            ReporteTiendaVO rp = new ReporteTiendaVO();
            rp = obtenerResumen(cmbTiendaBI.SelectedValue.ToString());

            List<ReporteTiendaVO> ListRp = new List<ReporteTiendaVO>();
            ListRp = obtenerResumenRubro(cmbTiendaBI.SelectedValue.ToString());

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            //CABECERAS
            ws.Cells[1, 1] = "Nombre Tienda";
            ws.Cells[1, 2] = "Usuarios registrados";
            ws.Cells[1, 3] = "Correos enviados";
            ws.Cells[1, 4] = "Valoraciones";
            ws.Cells[5, 1] = "Rubro";
            ws.Cells[5, 2] = "Descuentos";
            
            ws.Cells[1, 1].Interior.Color = Color.Orange;
            ws.Cells[1, 2].Interior.Color = Color.Orange;
            ws.Cells[1, 3].Interior.Color = Color.Orange;
            ws.Cells[1, 4].Interior.Color = Color.Orange;

            ws.Cells[5, 1].Interior.Color = Color.Orange;
            ws.Cells[5, 2].Interior.Color = Color.Orange;

            //DATOS
            ws.Cells[2, 1] = rp.nombreTienda;
            ws.Cells[2, 2] = rp.cantUsuarios;
            ws.Cells[2, 3] = rp.cantMail;
            ws.Cells[2, 4] = rp.cantValoracion;
            
            for (int f = 0; f < ListRp.Count; f++)
            {
                int fila = 6;
                int columna = 1;

                ws.Cells[fila, columna] = ListRp[f].nombreRubro;
                columna = columna + f+1;
                ws.Cells[fila, columna] = ListRp[f].cantidadDescuentos;
                fila = fila + f +1;
            }

            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = "*.xlsx";
            sd.FileName = "Informe por tienda";
            sd.Filter = "Archivos de Excel (*.xlsx)|*.xlsx ";
            sd.ShowDialog();
            ws.SaveAs(sd.FileName);
            
            MessageBox.Show("El archivo fue descargado con éxito.");
            ws = null;
            sd = null;
            excel.Quit();
        }

        private void cargarTiendas()
        {
            List<TiendaGridVO> lstTienda = new List<TiendaGridVO>();
            cmbTiendaBI.DataSource = null;
            TiendaDAO listaTienda = new TiendaDAO();
            lstTienda  = listaTienda.listarTiendas();
            cmbTiendaBI.DataSource = lstTienda;
            cmbTiendaBI.DisplayMember = "nombreTienda";
            cmbTiendaBI.ValueMember = "idTienda";
        }

        private ReporteTiendaVO obtenerResumen(String _idTienda)
        {
            ReporteTiendaVO rp = new ReporteTiendaVO();
            ReporteDAO repDAO = new ReporteDAO();
            rp = repDAO.listarReporte(_idTienda);
            return rp;
        }

        private List<ReporteTiendaVO> obtenerResumenRubro(String _idTienda)
        {
            List<ReporteTiendaVO> rp = new List<ReporteTiendaVO>();
            ReporteDAO repDAO = new ReporteDAO();
            rp = repDAO.listarRubro(_idTienda);
            return rp;
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
            else if (clickedItem.Name.Equals("11"))
            {
                ConsultaValoracion consultaValoracion = new ConsultaValoracion();
                consultaValoracion.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("5"))
            {
                ListarUsuarios rpt = new ListarUsuarios();
                rpt.Show();
                this.Hide();
            }
        }

        private void ResumenPorTienda_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
