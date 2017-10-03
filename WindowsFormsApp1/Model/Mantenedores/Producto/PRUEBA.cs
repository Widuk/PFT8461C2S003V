using System;
using System.Data;
using System.Drawing;
using PresentationControls;
using System.Windows.Forms;
using WindowsFormsApp1.Controler.DAO;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp1.Model.Mantenedores.Producto
{
    public partial class PRUEBA : Form
    {
        public PRUEBA()
        {
            InitializeComponent();
        }

        private void PRUEBA_Load(object sender, EventArgs e)
        {
            cmbAlgo.DataSource = null;
            TiendaDAO listaTiendaDT = new TiendaDAO();

            cmbAlgo.DataSource = listaTiendaDT.ListarTiendaDT();

            DataTable DT = listaTiendaDT.ListarTiendaDT();
            
            cmbAlgo.DataSource =
                new ListSelectionWrapper<DataRow>(DT.Rows,"NOMBRE");
            cmbAlgo.DisplayMemberSingleItem = "Name";
            cmbAlgo.DisplayMember = "NameConcatenated";
            cmbAlgo.ValueMember = "Selected";
        }


    }
}