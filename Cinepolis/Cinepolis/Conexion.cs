using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cinepolis
{
    class Conexion
    {
        public static SqlConnection ObtnerConexion()
        {
            SqlConnection conexion = new SqlConnection("Data source=DESKTOP-KS0D3KA\\SQLEXPRESS; Initial Catalog=Cinepolis; Integrated Security=true");
            conexion.Open();

            return conexion;
        }
    }
}
