using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    public class Oferta
    {
        public long idOferta { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public byte[] fotografia { get; set; }
        public int minimoProductos { get; set; }
        public int maximoProductos { get; set; }
        public short isPublicada { get; set; }
        public long idProducto { get; set; }
    }
}
