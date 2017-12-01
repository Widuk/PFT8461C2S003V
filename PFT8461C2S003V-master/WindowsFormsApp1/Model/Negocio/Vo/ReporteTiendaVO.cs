using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Vo
{
    class ReporteTiendaVO
    {
        public long idTienda { get; set; }
        public String nombreTienda { get; set; }
        public String cantUsuarios { get; set; }
        public String cantMail { get; set; }
        public String cantValoracion { get; set; }
        public String nombreRubro { get; set; }
        public String cantidadDescuentos { get; set; }
    }
}
