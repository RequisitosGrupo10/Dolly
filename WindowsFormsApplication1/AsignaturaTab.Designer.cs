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
            this.bExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bImport = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.grupo10DBDataSet3 = new WindowsFormsApplication1.grupo10DBDataSet3();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new WindowsFormsApplication1.grupo10DBDataSet3TableAdapters.AsignaturaTableAdapter();
            this.idAsignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(796, 332);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(56, 19);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "SALIR";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignaturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asignaturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(35, 26);
            this.bImport.Margin = new System.Windows.Forms.Padding(2);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(147, 75);
            this.bImport.TabIndex = 2;
            this.bImport.Text = "Importar Asignaturas";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(35, 121);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(147, 67);
            this.bBorrar.TabIndex = 3;
            this.bBorrar.Text = "Borrar Asignatura";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrarAsignatura_Click);
            // 
            // grupo10DBDataSet3
            // 
            this.grupo10DBDataSet3.DataSetName = "grupo10DBDataSet3";
            this.grupo10DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.grupo10DBDataSet3;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // idAsignaturaDataGridViewTextBoxColumn
            // 
            this.idAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "idAsignatura";
            this.idAsignaturaDataGridViewTextBoxColumn.HeaderText = "idAsignatura";
            this.idAsignaturaDataGridViewTextBoxColumn.Name = "idAsignaturaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // AsignaturaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 361);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsignaturaTab";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.AsignaturaTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bBorrar;
        private grupo10DBDataSet3 grupo10DBDataSet3;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private grupo10DBDataSet3TableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}