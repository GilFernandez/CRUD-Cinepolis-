using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cinepolis
{
    class Usuario
    {
        public static int CrearUsuario(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection Conn = Conexion.ObtnerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (nombreUsuario, clave) values ('{0}', PwdEncrypt('{1}') )", pUsuario, pContraseña), Conn);

            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            return resultado;
        }

        public static int Autentificar(String pUsuarios, String pContraseña)
        {
            int resultado = -1;

            SqlConnection conexion = Conexion.ObtnerConexion();

            SqlCommand comando = new SqlCommand(string.Format(
                "Select * From Usuario Where nombreUsuario = '{0}' and PwdCompare('{1}',clave) = 1 ", pUsuarios, pContraseña), conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            
            {
                VariableGlobal vGlobal = new VariableGlobal();
                vGlobal.IDUsuario = reader.GetInt32(0);
                resultado = vGlobal.IDUsuario;
            }

            conexion.Close();
            return resultado;
        }
    }
}
