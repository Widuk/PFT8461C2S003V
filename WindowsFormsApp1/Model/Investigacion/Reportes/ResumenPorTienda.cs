using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;

namespace WindowsFormsApp1.Model.Investigacion.Reportes
{
    public partial class ResumenPorTienda : Form
    {

        public ResumenPorTienda()
        {
            InitializeComponent();
        }

        private void btnDescargaResumen_Click(object sender, EventArgs e)
        {
            String resumen = obtenerResumen();
            SaveFileDialog svg = new SaveFileDialog();
            svg.ShowDialog();

            using (FileStream stream = new FileStream(svg.FileName + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A1, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph(resumen));
                pdfDoc.Close();
                stream.Close();
            }

        }

        private string obtenerResumen()
        {
            ConsumidorDAO consumidorDAO = new ConsumidorDAO();
            TrabajadorDAO trabajadorDAO = new TrabajadorDAO();
            ValoracionDAO valoracionDAO = new ValoracionDAO();
            DescuentoDAO descuentoDAO = new DescuentoDAO();
            LogEmailDAO logEmailDAO = new LogEmailDAO();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            TiendaDAO tiendaDAO = new TiendaDAO();
            RubroDAO rubroDAO = new RubroDAO();

            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine("Usuarios ");
            resumen.AppendLine();
            resumen.Append("Total de usuarios registrados: ");
            resumen.AppendLine(usuarioDAO.getTotalUsuariosRegistrados().ToString());
            resumen.Append("Trabajadores registrados: ");
            resumen.AppendLine(trabajadorDAO.getTotalTrabajadoresRegistrados().ToString());
            resumen.Append("Consumidores registrados: ");
            resumen.AppendLine(consumidorDAO.getTotalConsumidoresRegistrados().ToString());
            resumen.AppendLine();
            resumen.Append("Correos enviados: ");
            resumen.AppendLine(logEmailDAO.getTotalLogEmailEnviados().ToString());
            resumen.AppendLine();
            resumen.Append("Cantidad valoraciones: ");
            resumen.AppendLine(valoracionDAO.getTotalValoracionesRegistradas().ToString());
            resumen.AppendLine();
            resumen.AppendLine("Total de descuentos entregados por rubro");
            foreach(Rubro rubro in rubroDAO.listarRubros())
            {
                resumen.Append(rubro.nombre);
                resumen.Append(": ");
                resumen.AppendLine(descuentoDAO.getTotalDescuentosRegistradosPorRubro(rubro.idRubro).ToString());
            }

            consumidorDAO.getTotalConsumidoresRegistrados();
            label1.Text = resumen.ToString();
            return resumen.ToString();
        }

        private void ResumenPorTienda_Load(object sender, EventArgs e)
        {
            foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                itm.Click += new EventHandler(genericHandler);
                itm.Name = func.idFuncionalidad.ToString();
                this.menuStrip1.Items.Add(itm);
            }
        }

        private void genericHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem.Text.Equals("5"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
            }
            else if (clickedItem.Name.Equals("1"))
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
            else if (clickedItem.Name.Equals("12"))
            {
                ResumenPorTienda rpt = new ResumenPorTienda();
                rpt.Show();
                this.Hide();
            }
        }
    }
}
