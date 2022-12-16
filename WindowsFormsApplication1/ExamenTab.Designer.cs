namespace WindowsFormsApplication1
{
    partial class ExamenTab
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bImportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(21, 58);
            this.bImportar.Name = "bImportar";
            this.bImportar.Size = new System.Drawing.Size(144, 85);
            this.bImportar.TabIndex = 1;
            this.bImportar.Text = "Importar examen";
            this.bImportar.UseVisualStyleBackColor = true;
            this.bImportar.Click += new System.EventHandler(this.bImportar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar examen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(932, 327);
            this.bExit.Name = "bExit";
            this.bExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "SALIR";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // ExamenTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 364);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bImportar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExamenTab";
            this.Text = "ExamenTAB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bExit;
    }
}