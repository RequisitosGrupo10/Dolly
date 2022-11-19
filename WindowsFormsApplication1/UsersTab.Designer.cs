namespace WindowsFormsApplication1
{
    partial class UsersTab
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupo10DBDataSet = new WindowsFormsApplication1.grupo10DBDataSet();
            this.grupo10DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupo10DBDataSet1 = new WindowsFormsApplication1.grupo10DBDataSet1();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication1.grupo10DBDataSet1TableAdapters.UsuarioTableAdapter();
            this.grupo10DBDataSet6 = new WindowsFormsApplication1.grupo10DBDataSet6();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new WindowsFormsApplication1.grupo10DBDataSet6TableAdapters.UsuarioTableAdapter();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo10DBDataSet7 = new WindowsFormsApplication1.grupo10DBDataSet7();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter2 = new WindowsFormsApplication1.grupo10DBDataSet7TableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(42, 47);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(96, 82);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nombreRol});
            this.dataGridView1.DataSource = this.usuarioBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(233, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(691, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grupo10DBDataSet
            // 
            this.grupo10DBDataSet.DataSetName = "grupo10DBDataSet";
            this.grupo10DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupo10DBDataSetBindingSource
            // 
            this.grupo10DBDataSetBindingSource.DataSource = this.grupo10DBDataSet;
            this.grupo10DBDataSetBindingSource.Position = 0;
            // 
            // grupo10DBDataSet1
            // 
            this.grupo10DBDataSet1.DataSetName = "grupo10DBDataSet1";
            this.grupo10DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.grupo10DBDataSet1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // grupo10DBDataSet6
            // 
            this.grupo10DBDataSet6.DataSetName = "grupo10DBDataSet6";
            this.grupo10DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.grupo10DBDataSet6;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // nombreRol
            // 
            this.nombreRol.HeaderText = "nombreRol";
            this.nombreRol.Name = "nombreRol";
            // 
            // grupo10DBDataSet7
            // 
            this.grupo10DBDataSet7.DataSetName = "grupo10DBDataSet7";
            this.grupo10DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            this.usuarioBindingSource2.DataSource = this.grupo10DBDataSet7;
            // 
            // usuarioTableAdapter2
            // 
            this.usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // UsersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportar);
            this.Name = "UsersTab";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private grupo10DBDataSet grupo10DBDataSet;
        private System.Windows.Forms.BindingSource grupo10DBDataSetBindingSource;
        private grupo10DBDataSet1 grupo10DBDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private grupo10DBDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private grupo10DBDataSet6 grupo10DBDataSet6;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private grupo10DBDataSet6TableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRol;
        private grupo10DBDataSet7 grupo10DBDataSet7;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private grupo10DBDataSet7TableAdapters.UsuarioTableAdapter usuarioTableAdapter2;
    }
}