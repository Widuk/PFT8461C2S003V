using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Vo
{
    public class OfertaGridVO
    {
        public long idOferta { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int minimoProductos { get; set; }
        public int maximoProductos { get; set; }
        public string estado { get; set; }
        public string nombreProducto { get; set; }
        public string skuProducto { get; set; }
    }
}
