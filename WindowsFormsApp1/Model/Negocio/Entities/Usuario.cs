using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Negocio.Entities
{
    class Usuario
    {
        public long idUsuario { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public short isActivo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public String idSession { get; set; }
        public long codigoPerfil { get; set; }

    }
}
