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
            this.bImportar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bBorrarResponsable = new System.Windows.Forms.Button();
            this.bInserResponsable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(30, 22);
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
            this.bBorrar.Location = new System.Drawing.Point(30, 80);
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 144);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(112, 147);
            this.listBox1.TabIndex = 4;
            // 
            // bBorrarResponsable
            // 
            this.bBorrarResponsable.Location = new System.Drawing.Point(163, 224);
            this.bBorrarResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrarResponsable.Name = "bBorrarResponsable";
            this.bBorrarResponsable.Size = new System.Drawing.Size(164, 66);
            this.bBorrarResponsable.TabIndex = 5;
            this.bBorrarResponsable.Text = "Eliminar Responsable de Sede";
            this.bBorrarResponsable.UseVisualStyleBackColor = true;
            // 
            // bInserResponsable
            // 
            this.bInserResponsable.Location = new System.Drawing.Point(163, 144);
            this.bInserResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.bInserResponsable.Name = "bInserResponsable";
            this.bInserResponsable.Size = new System.Drawing.Size(164, 64);
            this.bInserResponsable.TabIndex = 3;
            this.bInserResponsable.Text = "Asignar Responsable de Sede";
            this.bInserResponsable.UseVisualStyleBackColor = true;
            // 
            // SedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 336);
            this.Controls.Add(this.bBorrarResponsable);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bInserResponsable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bImportar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SedeTab";
            this.Text = "Sedes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bBorrarResponsable;
        private System.Windows.Forms.Button bInserResponsable;
    }
}