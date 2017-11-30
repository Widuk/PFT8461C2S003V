using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Vo
{
    class DescuentoGridVO
    {
        public long idDescuento { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionDescuento { get; set; }
        public string isPorcentajeDescuento { get; set; }
        public double porcentajeDescuento { get; set; }
        public string isDescuentoDirecto { get; set; }
        public int precioDescuento { get; set; }
        public string skuProducto { get; set; }
    }
}
