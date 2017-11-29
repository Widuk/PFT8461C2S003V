using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Investigacion.Reportes;
using WindowsFormsApp1.Model.Mantenedores.BI;
using WindowsFormsApp1.Model.Mantenedores.Descuento;
using WindowsFormsApp1.Model.Mantenedores.Empresa;
using WindowsFormsApp1.Model.Mantenedores.Oferta;
using WindowsFormsApp1.Model.Mantenedores.Usuario;
using WindowsFormsApp1.Model.Mantenedores.Valoracion;
using WindowsFormsApp1.Model.Negocio.Entities;
using WindowsFormsApp1.Model.Negocio.SessionBag;

namespace WindowsFormsApp1.Model.Home
{
    public partial class Index: Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
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
                ListarDescuentos listarDesc = new ListarDescuentos();
                listarDesc.Show();
                this.Hide();
            }
            if (clickedItem.Name.Equals("5"))
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
            else if (clickedItem.Name.Equals("6"))
            {
                ListarOfertas listarOfertas = new ListarOfertas();
                listarOfertas.Show();
                this.Hide();
            }
        }
    }
}
