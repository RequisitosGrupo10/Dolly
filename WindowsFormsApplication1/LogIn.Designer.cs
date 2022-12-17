namespace WindowsFormsApplication1
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tContrasena = new System.Windows.Forms.TextBox();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.lInicio = new System.Windows.Forms.Label();
            this.cbVer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.AccessibleName = "nombre";
            this.tNombre.Location = new System.Drawing.Point(498, 214);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(132, 22);
            this.tNombre.TabIndex = 0;
            this.tNombre.Click += new System.EventHandler(this.tNombre_Click);
            this.tNombre.Enter += new System.EventHandler(this.tNombre_Click);
            // 
            // tContrasena
            // 
            this.tContrasena.AccessibleName = "password";
            this.tContrasena.Location = new System.Drawing.Point(498, 272);
            this.tContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.tContrasena.Name = "tContrasena";
            this.tContrasena.PasswordChar = '*';
            this.tContrasena.Size = new System.Drawing.Size(132, 22);
            this.tContrasena.TabIndex = 1;
            this.tContrasena.Click += new System.EventHandler(this.tContrasena_Click);
            this.tContrasena.Enter += new System.EventHandler(this.tContrasena_Click);
            this.tContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tContrasena_KeyPress);
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(394, 272);
            this.lContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(79, 16);
            this.lContraseña.TabIndex = 2;
            this.lContraseña.Text = "Contraseña:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(394, 217);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(59, 16);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Nombre:";
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Location = new System.Drawing.Point(450, 341);
            this.bIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(154, 66);
            this.bIniciarSesion.TabIndex = 4;
            this.bIniciarSesion.Text = "Iniciar Sesión";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Font = new System.Drawing.Font("Arial Black", 35F);
            this.lInicio.Location = new System.Drawing.Point(264, 90);
            this.lInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(549, 83);
            this.lInicio.TabIndex = 5;
            this.lInicio.Text = "Inicio de Sesión";
            // 
            // cbVer
            // 
            this.cbVer.AutoSize = true;
            this.cbVer.Location = new System.Drawing.Point(638, 272);
            this.cbVer.Margin = new System.Windows.Forms.Padding(4);
            this.cbVer.Name = "cbVer";
            this.cbVer.Size = new System.Drawing.Size(50, 20);
            this.cbVer.TabIndex = 6;
            this.cbVer.Text = "Ver";
            this.cbVer.UseVisualStyleBackColor = true;
            this.cbVer.CheckedChanged += new System.EventHandler(this.cbVer_CheckedChanged);
            // 
            // LogIn
            // 
            this.AccessibleName = "LogIn";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 441);
            this.Controls.Add(this.cbVer);
            this.Controls.Add(this.lInicio);
            this.Controls.Add(this.bIniciarSesion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.tContrasena);
            this.Controls.Add(this.tNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "DOLLY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tContrasena;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.CheckBox cbVer;
    }
}