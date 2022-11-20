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
            this.tContraseña = new System.Windows.Forms.TextBox();
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
            this.tNombre.Location = new System.Drawing.Point(227, 200);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 0;
            // 
            // tContraseña
            // 
            this.tContraseña.AccessibleName = "password";
            this.tContraseña.Location = new System.Drawing.Point(500, 200);
            this.tContraseña.Name = "tContraseña";
            this.tContraseña.PasswordChar = '*';
            this.tContraseña.Size = new System.Drawing.Size(100, 20);
            this.tContraseña.TabIndex = 1;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Location = new System.Drawing.Point(420, 207);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(64, 13);
            this.lContraseña.TabIndex = 2;
            this.lContraseña.Text = "Contraseña:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(161, 207);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Nombre:";
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Location = new System.Drawing.Point(316, 294);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(146, 23);
            this.bIniciarSesion.TabIndex = 4;
            this.bIniciarSesion.Text = "Iniciar Sesión";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lInicio.Location = new System.Drawing.Point(317, 65);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(167, 54);
            this.lInicio.TabIndex = 5;
            this.lInicio.Text = "INICIO";
            // 
            // cbVer
            // 
            this.cbVer.AutoSize = true;
            this.cbVer.Location = new System.Drawing.Point(609, 204);
            this.cbVer.Name = "cbVer";
            this.cbVer.Size = new System.Drawing.Size(42, 17);
            this.cbVer.TabIndex = 6;
            this.cbVer.Text = "Ver";
            this.cbVer.UseVisualStyleBackColor = true;
            this.cbVer.CheckedChanged += new System.EventHandler(this.cbVer_CheckedChanged);
            // 
            // LogIn
            // 
            this.AccessibleName = "LogIn";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbVer);
            this.Controls.Add(this.lInicio);
            this.Controls.Add(this.bIniciarSesion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.tContraseña);
            this.Controls.Add(this.tNombre);
            this.Name = "LogIn";
            this.Text = "DOLLY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tContraseña;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.CheckBox cbVer;
    }
}