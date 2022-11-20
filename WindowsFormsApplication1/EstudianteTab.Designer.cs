namespace WindowsFormsApplication1
{
    partial class EstudianteTab
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(917, 351);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 33);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "SALIR";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // alumnoBindingSource
            // 
            // 
            // dataGridEstudiantes
            // 
            this.dataGridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstudiantes.Location = new System.Drawing.Point(230, 12);
            this.dataGridEstudiantes.Name = "dataGridEstudiantes";
            this.dataGridEstudiantes.RowTemplate.Height = 24;
            this.dataGridEstudiantes.Size = new System.Drawing.Size(776, 309);
            this.dataGridEstudiantes.TabIndex = 2;
            this.dataGridEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // EstudianteTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 396);
            this.Controls.Add(this.dataGridEstudiantes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EstudianteTab";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.EstudianteTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridEstudiantes;
    }
}

