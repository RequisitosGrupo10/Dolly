namespace WindowsFormsApplication1
{
    partial class AsignaturaTab
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
            this.components = new System.ComponentModel.Container();
            this.bAtras = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bImportarAsignaturas = new System.Windows.Forms.Button();
            this.bEliminarAsignatura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(1061, 409);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 0;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(272, 32);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(864, 359);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            // 
            // bImportarAsignaturas
            // 
            this.bImportarAsignaturas.Location = new System.Drawing.Point(47, 107);
            this.bImportarAsignaturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bImportarAsignaturas.Name = "bImportarAsignaturas";
            this.bImportarAsignaturas.Size = new System.Drawing.Size(196, 92);
            this.bImportarAsignaturas.TabIndex = 2;
            this.bImportarAsignaturas.Text = "Importar Asignaturas";
            this.bImportarAsignaturas.UseVisualStyleBackColor = true;
            this.bImportarAsignaturas.Click += new System.EventHandler(this.bImportarAsignaturas_Click);
            // 
            // bEliminarAsignatura
            // 
            this.bEliminarAsignatura.Location = new System.Drawing.Point(47, 233);
            this.bEliminarAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminarAsignatura.Name = "bEliminarAsignatura";
            this.bEliminarAsignatura.Size = new System.Drawing.Size(196, 92);
            this.bEliminarAsignatura.TabIndex = 3;
            this.bEliminarAsignatura.Text = "Eliminar Asignatura";
            this.bEliminarAsignatura.UseVisualStyleBackColor = true;
            this.bEliminarAsignatura.Click += new System.EventHandler(this.bEliminarAsignatura_Click);
            // 
            // AsignaturaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 444);
            this.Controls.Add(this.bEliminarAsignatura);
            this.Controls.Add(this.bImportarAsignaturas);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bAtras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsignaturaTab";
            this.Text = "Asignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bImportarAsignaturas;
        private System.Windows.Forms.Button bEliminarAsignatura;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
    }
}