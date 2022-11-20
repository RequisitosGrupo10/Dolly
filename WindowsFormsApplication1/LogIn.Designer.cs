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
            this.nombre = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AccessibleName = "nombre";
            this.nombre.Location = new System.Drawing.Point(227, 200);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // password
            // 
            this.password.AccessibleName = "password";
            this.password.Location = new System.Drawing.Point(500, 200);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.Location = new System.Drawing.Point(302, 299);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(146, 23);
            this.iniciarSesion.TabIndex = 4;
            this.iniciarSesion.Text = "Iniciar Sesión";
            this.iniciarSesion.UseVisualStyleBackColor = true;
            this.iniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label3.Location = new System.Drawing.Point(293, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "INICIO";
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(609, 204);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(42, 17);
            this.ver.TabIndex = 6;
            this.ver.Text = "Ver";
            this.ver.UseVisualStyleBackColor = true;
            this.ver.CheckedChanged += new System.EventHandler(this.ver_CheckedChanged);
            // 
            // LogIn
            // 
            this.AccessibleName = "LogIn";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iniciarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nombre);
            this.Name = "LogIn";
            this.Text = "DOLLY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button iniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ver;
    }
}