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
            this.bImportar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sedeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bExit = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(30, 61);
            this.bImportar.Margin = new System.Windows.Forms.Padding(2);
            this.bImportar.Name = "bImportar";
            this.bImportar.Size = new System.Drawing.Size(297, 41);
            this.bImportar.TabIndex = 0;
            this.bImportar.Text = "Importar sedes";
            this.bImportar.UseVisualStyleBackColor = true;
            this.bImportar.Click += new System.EventHandler(this.bImport_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(30, 229);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(297, 42);
            this.bBorrar.TabIndex = 1;
            this.bBorrar.Text = "Borrar Sede";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrarSede_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // sedeBindingSource
            // 
            this.sedeBindingSource.DataMember = "Sede";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(755, 308);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(56, 19);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "SALIR";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(30, 143);
            this.bModificar.Margin = new System.Windows.Forms.Padding(2);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(297, 44);
            this.bModificar.TabIndex = 7;
            this.bModificar.Text = "Modificar Sede";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // SedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 336);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bImportar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SedeTab";
            this.Text = "Sedes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sedeBindingSource;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bModificar;
    }
}