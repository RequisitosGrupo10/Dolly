namespace WindowsFormsApplication1
{
    partial class GestionarProfesoresTab
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
            this.bAtras = new System.Windows.Forms.Button();
            this.lNombreSede = new System.Windows.Forms.Label();
            this.bImportarProfesores = new System.Windows.Forms.Button();
            this.bEliminarProfesores = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(694, 395);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(61, 21);
            this.bAtras.TabIndex = 4;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // lNombreSede
            // 
            this.lNombreSede.AutoSize = true;
            this.lNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSede.Location = new System.Drawing.Point(27, 24);
            this.lNombreSede.Name = "lNombreSede";
            this.lNombreSede.Size = new System.Drawing.Size(118, 20);
            this.lNombreSede.TabIndex = 18;
            this.lNombreSede.Text = "Nombre Sede";
            // 
            // bImportarProfesores
            // 
            this.bImportarProfesores.Location = new System.Drawing.Point(55, 126);
            this.bImportarProfesores.Name = "bImportarProfesores";
            this.bImportarProfesores.Size = new System.Drawing.Size(148, 70);
            this.bImportarProfesores.TabIndex = 19;
            this.bImportarProfesores.Text = "Importar Profesores";
            this.bImportarProfesores.UseVisualStyleBackColor = true;
            this.bImportarProfesores.Click += new System.EventHandler(this.bImportarProfesores_Click);
            // 
            // bEliminarProfesores
            // 
            this.bEliminarProfesores.Location = new System.Drawing.Point(55, 244);
            this.bEliminarProfesores.Name = "bEliminarProfesores";
            this.bEliminarProfesores.Size = new System.Drawing.Size(148, 70);
            this.bEliminarProfesores.TabIndex = 20;
            this.bEliminarProfesores.Text = "Eliminar Profesores";
            this.bEliminarProfesores.UseVisualStyleBackColor = true;
            this.bEliminarProfesores.Click += new System.EventHandler(this.bEliminarProfesores_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombre,
            this.rol});
            this.dataGridView.Location = new System.Drawing.Point(261, 70);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(481, 301);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.HeaderText = "rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // GestionarProfesoresTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bEliminarProfesores);
            this.Controls.Add(this.bImportarProfesores);
            this.Controls.Add(this.lNombreSede);
            this.Controls.Add(this.bAtras);
            this.Name = "GestionarProfesoresTab";
            this.Text = "GestionarProfesoresTab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label lNombreSede;
        private System.Windows.Forms.Button bImportarProfesores;
        private System.Windows.Forms.Button bEliminarProfesores;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}