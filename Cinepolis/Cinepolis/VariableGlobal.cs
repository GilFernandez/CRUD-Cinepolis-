using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis
{
    class VariableGlobal
    {
        public static Int32 idusuario;

        public Int32 IDUsuario
        {
            get
            {
                return idusuario;
            }
            set
            {
                idusuario = value;
            }
        }
    }
}
