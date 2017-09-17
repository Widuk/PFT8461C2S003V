using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    class Descuento
    {
        public long idDescuento { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public short isPorcentaje { get; set; }
        public double porcentajeDescuento { get; set; }
        public short isPrecioDirecto { get; set; }
        public int precioDescuento { get; set; }
        public long idProducto { get; set; }

    }
}
