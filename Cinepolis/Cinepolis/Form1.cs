using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinepolis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtUsuario.AutoSize = false;
            txtUsuario.Size = new Size(270, 25);
           

            txtClave.AutoSize = false;
            txtClave.Size = new Size(270, 25);

            lblUsuario.BackColor = Color.Transparent;
            lblClave.BackColor = Color.Transparent;
            chbxContraseña.BackColor = Color.Transparent;

            txtClave.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Usuario.Autentificar(txtUsuario.Text, txtClave.Text) > 0)
            {
                this.Hide();
                Pelicula f = new Pelicula();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error en los datos");
                txtClave.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
        }

        private void chbxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxContraseña.Checked == true)
            {
                if (txtClave.PasswordChar == '*')
                {
                    txtClave.PasswordChar = '\0';
                }
            }
            else
            {
                txtClave.PasswordChar = '*';
            }
        }
    }
}
