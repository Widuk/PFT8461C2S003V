using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    public class Funcionalidad
    {
        public long idFuncionalidad {get; set;}
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public short isActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public short isWeb { get; set; }
        public short isEscritorio { get; set; }
    }
}
