namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.bGestionarAsignaturas = new System.Windows.Forms.Button();
            this.bGestionarEstudiantes = new System.Windows.Forms.Button();
            this.bGestionarSedes = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGestionarUsuarios = new System.Windows.Forms.Button();
            this.bGestionarFranjasHorarias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGestionarAsignaturas
            // 
            this.bGestionarAsignaturas.Location = new System.Drawing.Point(39, 73);
            this.bGestionarAsignaturas.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarAsignaturas.Name = "bGestionarAsignaturas";
            this.bGestionarAsignaturas.Size = new System.Drawing.Size(169, 36);
            this.bGestionarAsignaturas.TabIndex = 0;
            this.bGestionarAsignaturas.Text = "Gestionar Asignaturas";
            this.bGestionarAsignaturas.UseVisualStyleBackColor = true;
            this.bGestionarAsignaturas.Click += new System.EventHandler(this.bGestionarAsignaturas_Click);
            // 
            // bGestionarEstudiantes
            // 
            this.bGestionarEstudiantes.Location = new System.Drawing.Point(39, 114);
            this.bGestionarEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarEstudiantes.Name = "bGestionarEstudiantes";
            this.bGestionarEstudiantes.Size = new System.Drawing.Size(169, 35);
            this.bGestionarEstudiantes.TabIndex = 1;
            this.bGestionarEstudiantes.Text = "Gestionar Estudiantes";
            this.bGestionarEstudiantes.UseVisualStyleBackColor = true;
            this.bGestionarEstudiantes.Click += new System.EventHandler(this.bGestionarEstudiantes_Click);
            // 
            // bGestionarSedes
            // 
            this.bGestionarSedes.Location = new System.Drawing.Point(39, 153);
            this.bGestionarSedes.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarSedes.Name = "bGestionarSedes";
            this.bGestionarSedes.Size = new System.Drawing.Size(169, 37);
            this.bGestionarSedes.TabIndex = 2;
            this.bGestionarSedes.Text = "Gestionar Sedes";
            this.bGestionarSedes.UseVisualStyleBackColor = true;
            this.bGestionarSedes.Click += new System.EventHandler(this.bGestionarSedes_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(718, 249);
            this.bSalir.Margin = new System.Windows.Forms.Padding(2);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(56, 19);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bGestionarUsuarios
            // 
            this.bGestionarUsuarios.Location = new System.Drawing.Point(39, 238);
            this.bGestionarUsuarios.Name = "bGestionarUsuarios";
            this.bGestionarUsuarios.Size = new System.Drawing.Size(169, 37);
            this.bGestionarUsuarios.TabIndex = 4;
            this.bGestionarUsuarios.Text = "Gestionar Usuarios";
            this.bGestionarUsuarios.UseVisualStyleBackColor = true;
            this.bGestionarUsuarios.Click += new System.EventHandler(this.bGestionarUsuarios_Click);
            // 
            // bGestionarFranjasHorarias
            // 
            this.bGestionarFranjasHorarias.Location = new System.Drawing.Point(39, 193);
            this.bGestionarFranjasHorarias.Name = "bGestionarFranjasHorarias";
            this.bGestionarFranjasHorarias.Size = new System.Drawing.Size(169, 39);
            this.bGestionarFranjasHorarias.TabIndex = 5;
            this.bGestionarFranjasHorarias.Text = "Gestionar Franjas Horarias";
            this.bGestionarFranjasHorarias.UseVisualStyleBackColor = true;
            this.bGestionarFranjasHorarias.Click += new System.EventHandler(this.bGestionarFranjasHorarias_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 287);
            this.Controls.Add(this.bGestionarFranjasHorarias);
            this.Controls.Add(this.bGestionarUsuarios);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGestionarSedes);
            this.Controls.Add(this.bGestionarEstudiantes);
            this.Controls.Add(this.bGestionarAsignaturas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGestionarAsignaturas;
        private System.Windows.Forms.Button bGestionarEstudiantes;
        private System.Windows.Forms.Button bGestionarSedes;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bGestionarUsuarios;
        private System.Windows.Forms.Button bGestionarFranjasHorarias;
    }
}