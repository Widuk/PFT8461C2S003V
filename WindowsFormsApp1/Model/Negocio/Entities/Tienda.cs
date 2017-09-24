using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    class Tienda
    {
        public long idTienda { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public sbyte isActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public String empresa { get; set; }
        public long ciudad_idCiudad { get; set; }
    }
}
