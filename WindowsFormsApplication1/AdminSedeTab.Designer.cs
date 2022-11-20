namespace WindowsFormsApplication1
{
    partial class AdminSedeTab
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
            this.lAforo = new System.Windows.Forms.Label();
            this.lDisponible = new System.Windows.Forms.Label();
            this.lResponsable = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.tAforo = new System.Windows.Forms.TextBox();
            this.tDisponible = new System.Windows.Forms.TextBox();
            this.tResponsable = new System.Windows.Forms.TextBox();
            this.lSede = new System.Windows.Forms.Label();
            this.bInserResponsable = new System.Windows.Forms.Button();
            this.bBorrarResponsable = new System.Windows.Forms.Button();
            this.listResponsable = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(422, 289);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // bImportar
            // 
            this.bImportar.Location = new System.Drawing.Point(23, 145);
            this.bImportar.Margin = new System.Windows.Forms.Padding(2);
            this.bImportar.Name = "bImportar";
            this.bImportar.Size = new System.Drawing.Size(297, 41);
            this.bImportar.TabIndex = 4;
            this.bImportar.Text = "Asignar Institutos";
            this.bImportar.UseVisualStyleBackColor = true;
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Location = new System.Drawing.Point(385, 30);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(32, 13);
            this.lAforo.TabIndex = 5;
            this.lAforo.Text = "Aforo";
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Location = new System.Drawing.Point(568, 30);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(56, 13);
            this.lDisponible.TabIndex = 6;
            this.lDisponible.Text = "Disponible";
            // 
            // lResponsable
            // 
            this.lResponsable.AutoSize = true;
            this.lResponsable.Location = new System.Drawing.Point(305, 71);
            this.lResponsable.Name = "lResponsable";
            this.lResponsable.Size = new System.Drawing.Size(112, 13);
            this.lResponsable.TabIndex = 7;
            this.lResponsable.Text = "Responsable de Sede";
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(687, 410);
            this.bExit.Margin = new System.Windows.Forms.Padding(2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(56, 19);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "SALIR";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tAforo
            // 
            this.tAforo.Location = new System.Drawing.Point(432, 27);
            this.tAforo.Name = "tAforo";
            this.tAforo.Size = new System.Drawing.Size(100, 20);
            this.tAforo.TabIndex = 9;
            // 
            // tDisponible
            // 
            this.tDisponible.Location = new System.Drawing.Point(643, 27);
            this.tDisponible.Name = "tDisponible";
            this.tDisponible.Size = new System.Drawing.Size(100, 20);
            this.tDisponible.TabIndex = 10;
            // 
            // tResponsable
            // 
            this.tResponsable.Location = new System.Drawing.Point(432, 68);
            this.tResponsable.Name = "tResponsable";
            this.tResponsable.Size = new System.Drawing.Size(192, 20);
            this.tResponsable.TabIndex = 11;
            // 
            // lSede
            // 
            this.lSede.AutoSize = true;
            this.lSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSede.Location = new System.Drawing.Point(65, 47);
            this.lSede.Name = "lSede";
            this.lSede.Size = new System.Drawing.Size(0, 42);
            this.lSede.TabIndex = 12;
            // 
            // bInserResponsable
            // 
            this.bInserResponsable.Location = new System.Drawing.Point(23, 218);
            this.bInserResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.bInserResponsable.Name = "bInserResponsable";
            this.bInserResponsable.Size = new System.Drawing.Size(297, 42);
            this.bInserResponsable.TabIndex = 13;
            this.bInserResponsable.Text = "Asignar Responsable de Sede";
            this.bInserResponsable.UseVisualStyleBackColor = true;
            this.bInserResponsable.Click += new System.EventHandler(this.bInserResponsable_Click);
            // 
            // bBorrarResponsable
            // 
            this.bBorrarResponsable.Location = new System.Drawing.Point(23, 276);
            this.bBorrarResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.bBorrarResponsable.Name = "bBorrarResponsable";
            this.bBorrarResponsable.Size = new System.Drawing.Size(297, 42);
            this.bBorrarResponsable.TabIndex = 14;
            this.bBorrarResponsable.Text = "Eliminar Responsable de Sede";
            this.bBorrarResponsable.UseVisualStyleBackColor = true;
            this.bBorrarResponsable.Click += new System.EventHandler(this.bBorrarResponsable_Click);
            // 
            // listResponsable
            // 
            this.listResponsable.FormattingEnabled = true;
            this.listResponsable.Location = new System.Drawing.Point(48, 335);
            this.listResponsable.Margin = new System.Windows.Forms.Padding(2);
            this.listResponsable.Name = "listResponsable";
            this.listResponsable.Size = new System.Drawing.Size(251, 82);
            this.listResponsable.TabIndex = 15;
            this.listResponsable.SelectedIndexChanged += new System.EventHandler(this.lResponsable_SelectedIndexChanged);
            // 
            // AdminSedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listResponsable);
            this.Controls.Add(this.bBorrarResponsable);
            this.Controls.Add(this.bInserResponsable);
            this.Controls.Add(this.lSede);
            this.Controls.Add(this.tResponsable);
            this.Controls.Add(this.tDisponible);
            this.Controls.Add(this.tAforo);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lResponsable);
            this.Controls.Add(this.lDisponible);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.bImportar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminSedeTab";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bImportar;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.Label lResponsable;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tAforo;
        private System.Windows.Forms.TextBox tDisponible;
        private System.Windows.Forms.TextBox tResponsable;
        private System.Windows.Forms.Label lSede;
        private System.Windows.Forms.Button bInserResponsable;
        private System.Windows.Forms.Button bBorrarResponsable;
        private System.Windows.Forms.ListBox listResponsable;
    }
}