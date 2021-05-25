using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cinepolis
{
    class Peliculas
    {
        public static int AgregarPelicula(string pNombre, string pClasificacion,int pEstatus)
        {
            VariableGlobal vGlobal = new VariableGlobal();
            int x = vGlobal.IDUsuario;

            int resultado = 0;
            SqlConnection Conn = Conexion.ObtnerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Pelicula (nombre, clasifiacion, estatus,idUsuarioCrea)" +
                                                                 " values ('{0}', '{1}','{2}','{3}')",
                                                                  pNombre, pClasificacion, pEstatus, x), Conn);

            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            return resultado;
        }

        public static string AgregarPeliculaSP(string pNombre, string pClasificacion, int pEstatus)
        {
            try
            {
                VariableGlobal vGlobal = new VariableGlobal();
                int x = vGlobal.IDUsuario;

                
                SqlConnection Conn = Conexion.ObtnerConexion();

                SqlCommand Comando = new SqlCommand("spAgregarPelicula", Conn);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add(new SqlParameter("@cNombre", pNombre));
                Comando.Parameters.Add(new SqlParameter("@cClasificacion", pClasificacion));
                Comando.Parameters.Add(new SqlParameter("@nEstatus", pEstatus));
                Comando.Parameters.Add(new SqlParameter("@nId_Usuario_Crea", x));

                SqlParameter p = new SqlParameter();
                p.ParameterName = "@cMensaje";
                p.SqlDbType = SqlDbType.VarChar;
                p.Size = 100;
                p.Direction = ParameterDirection.Output;

                Comando.Parameters.Add(p);
                Comando.ExecuteNonQuery();


                Conn.Close();
                return p.Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }



        public static int ModificarPelicula (string pNombre, string pClasificacion, int pEstatus, int pId)
        {
            VariableGlobal vGlobal = new VariableGlobal();
            int id = vGlobal.IDUsuario;

            int resultado = 0;
            SqlConnection Conn = Conexion.ObtnerConexion();

            string fecha = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;

            SqlCommand Comando = new SqlCommand(string.Format("UPDATE pelicula SET nombre = '{0}', clasifiacion  = '{1}', estatus = '{2}', idUsuarioModifica = '{3}', fechaModifica = '{4}'" +
                                                               "WHERE idPelicula = '{5}'", pNombre, pClasificacion, pEstatus,id,fecha, pId), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            return resultado;
        }

        public static int EliminarPelicula (int pId)
        {
            int x = 0;

            SqlConnection Conn = Conexion.ObtnerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Delete from Pelicula where idPelicula = '{0}'", pId), Conn);

            x = Comando.ExecuteNonQuery();
            Conn.Close();

            return x;
        }
    }
}
