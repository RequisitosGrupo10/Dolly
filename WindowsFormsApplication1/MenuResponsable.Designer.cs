namespace WindowsFormsApplication1
{
    partial class MenuResponsable
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
            this.lNombreSede = new System.Windows.Forms.Label();
            this.lAforo = new System.Windows.Forms.Label();
            this.tResponsableDeSede = new System.Windows.Forms.TextBox();
            this.lResponsableDeSede = new System.Windows.Forms.Label();
            this.tAforo = new System.Windows.Forms.TextBox();
            this.bGestionarSede = new System.Windows.Forms.Button();
            this.bGestionarAulas = new System.Windows.Forms.Button();
            this.bGestionarProfesores = new System.Windows.Forms.Button();
            this.bGestionarExamenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombreSede
            // 
            this.lNombreSede.AutoSize = true;
            this.lNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSede.Location = new System.Drawing.Point(312, 65);
            this.lNombreSede.Name = "lNombreSede";
            this.lNombreSede.Size = new System.Drawing.Size(191, 31);
            this.lNombreSede.TabIndex = 17;
            this.lNombreSede.Text = "Nombre Sede";
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Location = new System.Drawing.Point(315, 131);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(32, 13);
            this.lAforo.TabIndex = 18;
            this.lAforo.Text = "Aforo";
            // 
            // tResponsableDeSede
            // 
            this.tResponsableDeSede.Location = new System.Drawing.Point(362, 169);
            this.tResponsableDeSede.Name = "tResponsableDeSede";
            this.tResponsableDeSede.Size = new System.Drawing.Size(192, 20);
            this.tResponsableDeSede.TabIndex = 22;
            // 
            // lResponsableDeSede
            // 
            this.lResponsableDeSede.AutoSize = true;
            this.lResponsableDeSede.Location = new System.Drawing.Point(235, 172);
            this.lResponsableDeSede.Name = "lResponsableDeSede";
            this.lResponsableDeSede.Size = new System.Drawing.Size(112, 13);
            this.lResponsableDeSede.TabIndex = 20;
            this.lResponsableDeSede.Text = "Responsable de Sede";
            // 
            // tAforo
            // 
            this.tAforo.Location = new System.Drawing.Point(362, 128);
            this.tAforo.Name = "tAforo";
            this.tAforo.Size = new System.Drawing.Size(100, 20);
            this.tAforo.TabIndex = 21;
            // 
            // bGestionarSede
            // 
            this.bGestionarSede.Location = new System.Drawing.Point(318, 243);
            this.bGestionarSede.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarSede.Name = "bGestionarSede";
            this.bGestionarSede.Size = new System.Drawing.Size(185, 53);
            this.bGestionarSede.TabIndex = 23;
            this.bGestionarSede.Text = "Gestionar Sede";
            this.bGestionarSede.UseVisualStyleBackColor = true;
            this.bGestionarSede.Click += new System.EventHandler(this.bGestionarSede_Click);
            // 
            // bGestionarAulas
            // 
            this.bGestionarAulas.Location = new System.Drawing.Point(61, 325);
            this.bGestionarAulas.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarAulas.Name = "bGestionarAulas";
            this.bGestionarAulas.Size = new System.Drawing.Size(185, 53);
            this.bGestionarAulas.TabIndex = 24;
            this.bGestionarAulas.Text = "Gestionar Aulas";
            this.bGestionarAulas.UseVisualStyleBackColor = true;
            this.bGestionarAulas.Click += new System.EventHandler(this.bGestionarAulas_Click);
            // 
            // bGestionarProfesores
            // 
            this.bGestionarProfesores.Location = new System.Drawing.Point(318, 325);
            this.bGestionarProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarProfesores.Name = "bGestionarProfesores";
            this.bGestionarProfesores.Size = new System.Drawing.Size(185, 53);
            this.bGestionarProfesores.TabIndex = 25;
            this.bGestionarProfesores.Text = "Gestionar Profesores";
            this.bGestionarProfesores.UseVisualStyleBackColor = true;
            this.bGestionarProfesores.Click += new System.EventHandler(this.bGestionarProfesores_Click);
            // 
            // bGestionarExamenes
            // 
            this.bGestionarExamenes.Location = new System.Drawing.Point(561, 325);
            this.bGestionarExamenes.Margin = new System.Windows.Forms.Padding(2);
            this.bGestionarExamenes.Name = "bGestionarExamenes";
            this.bGestionarExamenes.Size = new System.Drawing.Size(185, 53);
            this.bGestionarExamenes.TabIndex = 26;
            this.bGestionarExamenes.Text = "Gestionar Exámenes";
            this.bGestionarExamenes.UseVisualStyleBackColor = true;
            // 
            // MenuResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGestionarExamenes);
            this.Controls.Add(this.bGestionarProfesores);
            this.Controls.Add(this.bGestionarAulas);
            this.Controls.Add(this.bGestionarSede);
            this.Controls.Add(this.tResponsableDeSede);
            this.Controls.Add(this.tAforo);
            this.Controls.Add(this.lResponsableDeSede);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.lNombreSede);
            this.Name = "MenuResponsable";
            this.Text = "MenuResponsable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombreSede;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.TextBox tResponsableDeSede;
        private System.Windows.Forms.Label lResponsableDeSede;
        private System.Windows.Forms.TextBox tAforo;
        private System.Windows.Forms.Button bGestionarSede;
        private System.Windows.Forms.Button bGestionarAulas;
        private System.Windows.Forms.Button bGestionarProfesores;
        private System.Windows.Forms.Button bGestionarExamenes;
    }
}