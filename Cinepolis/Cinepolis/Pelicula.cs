using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinepolis
{
    public partial class Pelicula : Form
    {
        int idPelicula;
        public Pelicula()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int x;
            if (chbxEstatus.Checked == true)
            {
                x = 1;
            }
            else
            {
                x = 0;
            }

            if (Peliculas.AgregarPeliculaSP(txtNombre.Text, cbxClasificacion.Text, x) != "")
            {
                MessageBox.Show("La pelicula fue agregado");
            }
            else
            {
                MessageBox.Show("No se pudo agregar la pelicula");
            }

            txtBuscarNombre.Clear();
            SqlConnection Conn = Conexion.ObtnerConexion();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwPelicula";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvPelicula.DataSource = dt;

            Conn.Close();
        }

        private void txtBuscarNombre_KeyUp(object sender, KeyEventArgs e)
        {

            SqlConnection Conn = Conexion.ObtnerConexion();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwPelicula where nombre like ('%" + txtBuscarNombre.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvPelicula.DataSource = dt;

            Conn.Close();
        }

        private void Pelicula_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = Conexion.ObtnerConexion();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwPelicula";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvPelicula.DataSource = dt;

            Conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Peliculas.EliminarPelicula(idPelicula) > 0)
            {
                MessageBox.Show("Se eliminó la pelicula con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la pelicula");
            }
            txtBuscarNombre.Clear();
            SqlConnection Conn = Conexion.ObtnerConexion();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwPelicula";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvPelicula.DataSource = dt;

            Conn.Close();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idPelicula = int.Parse(dgvPelicula.CurrentRow.Cells[0].Value.ToString());

                txtNombre.Text = dgvPelicula.CurrentRow.Cells[1].Value.ToString();
                cbxClasificacion.Text = dgvPelicula.CurrentRow.Cells[2].Value.ToString();

                if (dgvPelicula.CurrentRow.Cells[3].Value.ToString() == "1")
                {
                    chbxEstatus.Checked = true;
                }
                else
                {
                    chbxEstatus.Checked = false;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Selecciona una fila con datos");
               
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int x;
            if (chbxEstatus.Checked == true)
            {
                x = 1;
            }
            else
            {
                x = 0;
            }
            if (Peliculas.ModificarPelicula(txtNombre.Text,cbxClasificacion.Text,x,idPelicula) > 0)
            {
                MessageBox.Show("Se modificó la pelicula con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo modificar la pelicula");
            }

            txtBuscarNombre.Clear();
            SqlConnection Conn = Conexion.ObtnerConexion();
            SqlCommand cmd = Conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwPelicula";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgvPelicula.DataSource = dt;

            Conn.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 pg = new Form1();
            pg.Show();
        }
    }
}
