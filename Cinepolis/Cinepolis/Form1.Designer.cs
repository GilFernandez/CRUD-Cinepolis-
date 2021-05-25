namespace Cinepolis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chbxContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(149, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(209, 24);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(149, 95);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(209, 24);
            this.txtClave.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(28, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(28, 98);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(115, 18);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "CONTRASEÑA:";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(99, 273);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(227, 69);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // chbxContraseña
            // 
            this.chbxContraseña.AutoSize = true;
            this.chbxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxContraseña.Location = new System.Drawing.Point(31, 141);
            this.chbxContraseña.Name = "chbxContraseña";
            this.chbxContraseña.Size = new System.Drawing.Size(142, 20);
            this.chbxContraseña.TabIndex = 5;
            this.chbxContraseña.Text = "Mostrar contraseña";
            this.chbxContraseña.UseVisualStyleBackColor = true;
            this.chbxContraseña.CheckedChanged += new System.EventHandler(this.chbxContraseña_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 372);
            this.Controls.Add(this.chbxContraseña);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cinepolis - Proyección";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.CheckBox chbxContraseña;
    }
}

