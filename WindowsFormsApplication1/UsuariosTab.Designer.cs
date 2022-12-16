namespace WindowsFormsApplication1
{
    partial class UsuariosTab
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
            this.bImportarUsuarios = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportarUsuarios
            // 
            this.bImportarUsuarios.Location = new System.Drawing.Point(51, 58);
            this.bImportarUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bImportarUsuarios.Name = "bImportarUsuarios";
            this.bImportarUsuarios.Size = new System.Drawing.Size(197, 86);
            this.bImportarUsuarios.TabIndex = 0;
            this.bImportarUsuarios.Text = "Importar Usuarios";
            this.bImportarUsuarios.UseVisualStyleBackColor = true;
            this.bImportarUsuarios.Click += new System.EventHandler(this.bImportarUsuarios_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombre,
            this.rol});
            this.dataGridView.Location = new System.Drawing.Point(311, 58);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(700, 384);
            this.dataGridView.TabIndex = 1;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.HeaderText = "rol";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(921, 486);
            this.bAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(100, 28);
            this.bAtras.TabIndex = 2;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // UsuariosTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bImportarUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsuariosTab";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImportarUsuarios;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bAtras;
        // TODO: eliminar por no utilizar;
        //       private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        //       private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;  
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}