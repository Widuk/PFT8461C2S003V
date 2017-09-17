using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    class Producto
    {
        public long idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public int precio { get; set; }
        public short isDosPorUno { get; set; }
        public string SKU { get; set; }
        public short isActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public long idTienda { get; set; }
        public long idRubro { get; set; }

    }
}
