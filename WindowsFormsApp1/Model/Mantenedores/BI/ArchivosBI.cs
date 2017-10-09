using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Negocio.Vo;

namespace WindowsFormsApp1.Model.Mantenedores.BI
{
    public partial class ArchivosBI : Form
    {
        List<TiendaGridVO> listaTienda = new List<TiendaGridVO>();

        public ArchivosBI()
        {
            InitializeComponent();
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaTienda.Count == 0)
                {
                    MessageBox.Show("No existen tiendas para descargar.");
                    return;
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
                foreach (TiendaGridVO t in listaTienda)
                {
                    csvcontent.AppendLine(t.nombreTienda+";"+t.direccion + ";" + t.nombreCiudad + ";" + t.empresa + ";" + t.fechaCreacion + ";" + t.fechaModificacion);
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
            TiendaDAO Tiendas = new TiendaDAO();
            listaTienda = Tiendas.lt();
            biToolStripMenuItem.ForeColor = Color.Gray;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("descuentosToolStripMenuItem"))
            {
                ListarDescuentos listardesc = new ListarDescuentos();
                listardesc.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("tiendasToolStripMenuItem"))
            {
                PortadaMantenedorTienda mantTienda = new PortadaMantenedorTienda();
                mantTienda.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("productosToolStripMenuItem"))
            {
                PortadaMantenedorProducto mantProd = new PortadaMantenedorProducto();
                mantProd.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("usuariosToolStripMenuItem"))
            {
                ListarUsuarios listarUsu = new ListarUsuarios();
                listarUsu.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name.Equals("ofertasToolStripMenuItem"))
            {
                ListarOfertas listarOfertas = new ListarOfertas();
                listarOfertas.Show();
                this.Hide();
            }
        }
    }
}
