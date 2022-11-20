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
            this.nombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupo10DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(56, 58);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(128, 101);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreRol});
            this.dataGridView1.Location = new System.Drawing.Point(311, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 384);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreRol
            // 
            this.nombreRol.HeaderText = "nombreRol";
            this.nombreRol.Name = "nombreRol";
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(921, 486);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            // 
            // UsersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersTab";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo10DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource grupo10DBDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRol;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
    }
}