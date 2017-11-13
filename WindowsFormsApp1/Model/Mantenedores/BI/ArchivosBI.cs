using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Investigacion.Reportes;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.BI
{
    public partial class ArchivosBI : Form
    {
        List<OfertaGridVO> listaOferta = new List<OfertaGridVO>();

        public ArchivosBI()
        {
            InitializeComponent();
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            CargaOfertas();
            try
            {
                if (listaOferta.Count == 0)
                {
                    MessageBox.Show("No existen tiendas para descargar.");
                    return;
                }

                try
                {
                    FolderBrowserDialog pathDescargaArchivo = new FolderBrowserDialog();
                    pathDescargaArchivo.Description = "Seleccione donde quiere descargar el archivo";
                    if (pathDescargaArchivo.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Usted seleccionó: " + pathDescargaArchivo.SelectedPath);
                    }
                    else
                    {
                        MessageBox.Show("Se canceló la descarga del archivo.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error grave Cargando imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                String csvpath = "C:\\Users\\"+ Environment.UserName + "\\Desktop\\Lista_de_tiendas.csv";

                if (File.Exists(csvpath))
                {
                    DialogResult result = MessageBox.Show("El archivo ya existe. Desea sobreescribirlo.?", "Sobreescribir archivo", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(csvpath);
                        MessageBox.Show("Archivo sobreescrito.");
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                
                StringBuilder csvcontent = new StringBuilder();
                csvcontent.AppendLine("Nombre de tienda;Direccion;Ciudad;Empresa;Fecha creacion;Fecha modificacion");
                foreach (OfertaGridVO o in listaOferta)
                {
                    csvcontent.AppendLine(o.skuProducto + ";" + o.nombreProducto + ";" + o.estado + ";" + o.minimoProductos + ";" + o.maximoProductos + ";" + o.fechaInicio + ";" + o.fechaFin);
                }
                File.AppendAllText(csvpath, csvcontent.ToString());
                MessageBox.Show("El archivo fue descargado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar archivo BI.");
                return;
            }
        }

        private void ArchivosBI_Load(object sender, EventArgs e)
        {
            lblUsuarioIngreso.Text = "Bienvenido(a): " + objetoPaso.pasoUsuario;
            objetoPaso.limpiaPaso();
            foreach (Funcionalidad func in SesionBag.usuarioSesionado.funcionalidadesUsuario)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem(func.nombre);
                itm.Click += new EventHandler(genericHandler);
                itm.Name = func.idFuncionalidad.ToString();
                if (itm.Name.Equals("10"))
                {
                    itm.ForeColor = Color.Gray;
                }
                this.menuStrip1.Items.Add(itm);
            }
        }

        private void CargaOfertas()
        {
            try
            {
                OfertaDAO Oferta = new OfertaDAO();
                listaOferta = Oferta.getListaOfertasGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al listar las ofertas. Favor comunique a soporte.");
                return;
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
                ListarDescuentos listardesc = new ListarDescuentos();
                listardesc.Show();
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
            Application.Exit();
        }
    }
}
