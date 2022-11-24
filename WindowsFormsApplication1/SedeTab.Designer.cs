namespace WindowsFormsApplication1
{
    partial class SedeTab
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
            this.bImportarSedes = new System.Windows.Forms.Button();
            this.bEliminarSede = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAtras = new System.Windows.Forms.Button();
            this.bModificarSede = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportarSedes
            // 
            this.bImportarSedes.Location = new System.Drawing.Point(40, 75);
            this.bImportarSedes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bImportarSedes.Name = "bImportarSedes";
            this.bImportarSedes.Size = new System.Drawing.Size(396, 50);
            this.bImportarSedes.TabIndex = 0;
            this.bImportarSedes.Text = "Importar Sedes";
            this.bImportarSedes.UseVisualStyleBackColor = true;
            this.bImportarSedes.Click += new System.EventHandler(this.bImportarSedes_Click);
            // 
            // bEliminarSede
            // 
            this.bEliminarSede.Location = new System.Drawing.Point(40, 282);
            this.bEliminarSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminarSede.Name = "bEliminarSede";
            this.bEliminarSede.Size = new System.Drawing.Size(396, 52);
            this.bEliminarSede.TabIndex = 1;
            this.bEliminarSede.Text = "Eliminar Sede";
            this.bEliminarSede.UseVisualStyleBackColor = true;
            this.bEliminarSede.Click += new System.EventHandler(this.bEliminarSede_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(472, 27);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(661, 336);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // sedeBindingSource
            // 
            this.sedeBindingSource.DataMember = "Sede";
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(1007, 379);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 6;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bModificarSede
            // 
            this.bModificarSede.Location = new System.Drawing.Point(40, 176);
            this.bModificarSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bModificarSede.Name = "bModificarSede";
            this.bModificarSede.Size = new System.Drawing.Size(396, 54);
            this.bModificarSede.TabIndex = 7;
            this.bModificarSede.Text = "Modificar Sede";
            this.bModificarSede.UseVisualStyleBackColor = true;
            this.bModificarSede.Click += new System.EventHandler(this.bModificarSede_Click);
            // 
            // SedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 414);
            this.Controls.Add(this.bModificarSede);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bEliminarSede);
            this.Controls.Add(this.bImportarSedes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SedeTab";
            this.Text = "Sedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImportarSedes;
        private System.Windows.Forms.Button bEliminarSede;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource sedeBindingSource;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bModificarSede;
    }
}