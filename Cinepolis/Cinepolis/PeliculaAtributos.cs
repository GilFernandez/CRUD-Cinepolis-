using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis
{
    public class PeliculaAtributos
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Clasificacion { get; set; }
        public Int32 Estatus { get; set; }
        public Int32 UsuarioCrea { get; set; }
        public String fechaCrea { get; set; }
        public Int32 UsuarioModifica { get; set; }
        public String fechaModifica { get; set; }

        public PeliculaAtributos (Int32 pId, String pNombre, String pClasificacion, Int32 pEstatus, Int32 pUsuarioCrea, 
            String pFechaCrea, Int32 pUsuarioModifica, String pFechaModifica)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Clasificacion = pClasificacion;
            this.Estatus = pEstatus;
            this.UsuarioCrea = pUsuarioCrea;
            this.fechaCrea = pFechaCrea;
            this.UsuarioModifica = pUsuarioModifica;
            this.fechaModifica = pFechaModifica;
        }
    }
}
