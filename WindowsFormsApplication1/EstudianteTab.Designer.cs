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
            this.bAtras = new System.Windows.Forms.Button();
            this.bImportarEstudiantes = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bBorrarEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAtras.Location = new System.Drawing.Point(917, 351);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(89, 33);
            this.bAtras.TabIndex = 0;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bImportarEstudiantes
            // 
            this.bImportarEstudiantes.Location = new System.Drawing.Point(23, 12);
            this.bImportarEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bImportarEstudiantes.Name = "bImportarEstudiantes";
            this.bImportarEstudiantes.Size = new System.Drawing.Size(159, 75);
            this.bImportarEstudiantes.TabIndex = 1;
            this.bImportarEstudiantes.Text = "Importar Estudiantes";
            this.bImportarEstudiantes.UseVisualStyleBackColor = true;
            this.bImportarEstudiantes.Click += new System.EventHandler(this.bImportarEstudiantes_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(229, 12);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 309);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // bBorrar
            // 
            this.bBorrar.BackColor = System.Drawing.Color.Gold;
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(23, 239);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(159, 82);
            this.bBorrar.TabIndex = 3;
            this.bBorrar.Text = "Borrar todos los estudiantes";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bBorrarEstudiante
            // 
            this.bBorrarEstudiante.Location = new System.Drawing.Point(23, 131);
            this.bBorrarEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBorrarEstudiante.Name = "bBorrarEstudiante";
            this.bBorrarEstudiante.Size = new System.Drawing.Size(159, 75);
            this.bBorrarEstudiante.TabIndex = 4;
            this.bBorrarEstudiante.Text = "Borrar Estudiante";
            this.bBorrarEstudiante.UseVisualStyleBackColor = true;
            this.bBorrarEstudiante.Click += new System.EventHandler(this.button1_Click);
            // 
            // EstudianteTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 396);
            this.Controls.Add(this.bBorrarEstudiante);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bImportarEstudiantes);
            this.Controls.Add(this.bAtras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EstudianteTab";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.EstudianteTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bImportarEstudiantes;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bBorrarEstudiante;
    }
}

