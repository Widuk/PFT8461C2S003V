using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Vo
{
    public class ReporteValoracionVO
    {
        public int notaValoracion { get; set; }
        public string detalleValoracion { get; set; }
        public DateTime fechaValoracion { get; set; }
        public long codigoOferta { get; set; }
        public DateTime fechaInicioOferta { get; set; }
        public DateTime fechaTerminoOferta { get; set; }
        public long codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public int precioProducto { get; set; }
        public string rutConsumidor { get; set; }
        public string nombreConsumidor { get; set; }

    }
}
