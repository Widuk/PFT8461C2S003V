using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Vo
{
    class TiendaGridVO
    {
        public long idTienda { get; set; }
        public String nombreTienda { get; set; }
        public String direccion { get; set; }
        public String nombreCiudad { get; set; }
        public String telefono { get; set; }
        public sbyte isActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public String empresa { get; set; }
        public long idCiudad { get; set; }
    }
}
