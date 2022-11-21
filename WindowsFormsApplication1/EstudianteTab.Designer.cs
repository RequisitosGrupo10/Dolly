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
            this.bEliminarTodosLosEstudiantes = new System.Windows.Forms.Button();
            this.bEliminarEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAtras.Location = new System.Drawing.Point(688, 285);
            this.bAtras.Margin = new System.Windows.Forms.Padding(2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(67, 27);
            this.bAtras.TabIndex = 0;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bImportarEstudiantes
            // 
            this.bImportarEstudiantes.Location = new System.Drawing.Point(17, 10);
            this.bImportarEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.bImportarEstudiantes.Name = "bImportarEstudiantes";
            this.bImportarEstudiantes.Size = new System.Drawing.Size(119, 61);
            this.bImportarEstudiantes.TabIndex = 1;
            this.bImportarEstudiantes.Text = "Importar Estudiantes";
            this.bImportarEstudiantes.UseVisualStyleBackColor = true;
            this.bImportarEstudiantes.Click += new System.EventHandler(this.bImportarEstudiantes_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(172, 10);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(582, 251);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // bEliminarTodosLosEstudiantes
            // 
            this.bEliminarTodosLosEstudiantes.BackColor = System.Drawing.Color.Gold;
            this.bEliminarTodosLosEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminarTodosLosEstudiantes.Location = new System.Drawing.Point(17, 194);
            this.bEliminarTodosLosEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.bEliminarTodosLosEstudiantes.Name = "bEliminarTodosLosEstudiantes";
            this.bEliminarTodosLosEstudiantes.Size = new System.Drawing.Size(119, 67);
            this.bEliminarTodosLosEstudiantes.TabIndex = 3;
            this.bEliminarTodosLosEstudiantes.Text = "Borrar Todos Los Estudiantes";
            this.bEliminarTodosLosEstudiantes.UseVisualStyleBackColor = false;
            this.bEliminarTodosLosEstudiantes.Click += new System.EventHandler(this.bEliminarTodosLosEstudiantes_Click);
            // 
            // bEliminarEstudiante
            // 
            this.bEliminarEstudiante.Location = new System.Drawing.Point(17, 106);
            this.bEliminarEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.bEliminarEstudiante.Name = "bEliminarEstudiante";
            this.bEliminarEstudiante.Size = new System.Drawing.Size(119, 61);
            this.bEliminarEstudiante.TabIndex = 4;
            this.bEliminarEstudiante.Text = "Eliminar Estudiante";
            this.bEliminarEstudiante.UseVisualStyleBackColor = true;
            this.bEliminarEstudiante.Click += new System.EventHandler(this.bEliminarEstudiante_Click);
            // 
            // EstudianteTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 322);
            this.Controls.Add(this.bEliminarEstudiante);
            this.Controls.Add(this.bEliminarTodosLosEstudiantes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bImportarEstudiantes);
            this.Controls.Add(this.bAtras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EstudianteTab";
            this.Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bImportarEstudiantes;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bEliminarTodosLosEstudiantes;
        private System.Windows.Forms.Button bEliminarEstudiante;
    }
}

