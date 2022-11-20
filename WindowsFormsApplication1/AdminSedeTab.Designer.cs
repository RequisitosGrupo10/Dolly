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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bAsignarCentros = new System.Windows.Forms.Button();
            this.lAforo = new System.Windows.Forms.Label();
            this.lDisponible = new System.Windows.Forms.Label();
            this.lResponsableDeSede = new System.Windows.Forms.Label();
            this.bAtras = new System.Windows.Forms.Button();
            this.tAforo = new System.Windows.Forms.TextBox();
            this.tDisponible = new System.Windows.Forms.TextBox();
            this.tResponsableDeSede = new System.Windows.Forms.TextBox();
            this.bAsignarResponsableDeSede = new System.Windows.Forms.Button();
            this.bQuitarResponsableDeSede = new System.Windows.Forms.Button();
            this.listResponsableDeSede = new System.Windows.Forms.ListBox();
            this.lNombreSede = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(338, 104);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(422, 289);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // bAsignarCentros
            // 
            this.bAsignarCentros.Location = new System.Drawing.Point(23, 145);
            this.bAsignarCentros.Margin = new System.Windows.Forms.Padding(2);
            this.bAsignarCentros.Name = "bAsignarCentros";
            this.bAsignarCentros.Size = new System.Drawing.Size(297, 41);
            this.bAsignarCentros.TabIndex = 4;
            this.bAsignarCentros.Text = "Asignar Centros";
            this.bAsignarCentros.UseVisualStyleBackColor = true;
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
            // lResponsableDeSede
            // 
            this.lResponsableDeSede.AutoSize = true;
            this.lResponsableDeSede.Location = new System.Drawing.Point(305, 71);
            this.lResponsableDeSede.Name = "lResponsableDeSede";
            this.lResponsableDeSede.Size = new System.Drawing.Size(112, 13);
            this.lResponsableDeSede.TabIndex = 7;
            this.lResponsableDeSede.Text = "Responsable de Sede";
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(687, 410);
            this.bAtras.Margin = new System.Windows.Forms.Padding(2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(56, 19);
            this.bAtras.TabIndex = 8;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
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
            // tResponsableDeSede
            // 
            this.tResponsableDeSede.Location = new System.Drawing.Point(432, 68);
            this.tResponsableDeSede.Name = "tResponsableDeSede";
            this.tResponsableDeSede.Size = new System.Drawing.Size(192, 20);
            this.tResponsableDeSede.TabIndex = 11;
            // 
            // bAsignarResponsableDeSede
            // 
            this.bAsignarResponsableDeSede.Location = new System.Drawing.Point(23, 218);
            this.bAsignarResponsableDeSede.Margin = new System.Windows.Forms.Padding(2);
            this.bAsignarResponsableDeSede.Name = "bAsignarResponsableDeSede";
            this.bAsignarResponsableDeSede.Size = new System.Drawing.Size(297, 42);
            this.bAsignarResponsableDeSede.TabIndex = 13;
            this.bAsignarResponsableDeSede.Text = "Asignar Responsable de Sede";
            this.bAsignarResponsableDeSede.UseVisualStyleBackColor = true;
            this.bAsignarResponsableDeSede.Click += new System.EventHandler(this.bAsignarResponsableDeSede_Click);
            // 
            // bQuitarResponsableDeSede
            // 
            this.bQuitarResponsableDeSede.Location = new System.Drawing.Point(23, 276);
            this.bQuitarResponsableDeSede.Margin = new System.Windows.Forms.Padding(2);
            this.bQuitarResponsableDeSede.Name = "bQuitarResponsableDeSede";
            this.bQuitarResponsableDeSede.Size = new System.Drawing.Size(297, 42);
            this.bQuitarResponsableDeSede.TabIndex = 14;
            this.bQuitarResponsableDeSede.Text = "Quitar Responsable de Sede";
            this.bQuitarResponsableDeSede.UseVisualStyleBackColor = true;
            this.bQuitarResponsableDeSede.Click += new System.EventHandler(this.bQuitarResponsableDeSede_Click);
            // 
            // listResponsableDeSede
            // 
            this.listResponsableDeSede.FormattingEnabled = true;
            this.listResponsableDeSede.Location = new System.Drawing.Point(48, 335);
            this.listResponsableDeSede.Margin = new System.Windows.Forms.Padding(2);
            this.listResponsableDeSede.Name = "listResponsableDeSede";
            this.listResponsableDeSede.Size = new System.Drawing.Size(251, 82);
            this.listResponsableDeSede.TabIndex = 15;
            this.listResponsableDeSede.SelectedIndexChanged += new System.EventHandler(this.lResponsableDeSede_SelectedIndexChanged);
            // 
            // lNombreSede
            // 
            this.lNombreSede.AutoSize = true;
            this.lNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSede.Location = new System.Drawing.Point(20, 27);
            this.lNombreSede.Name = "lNombreSede";
            this.lNombreSede.Size = new System.Drawing.Size(118, 20);
            this.lNombreSede.TabIndex = 16;
            this.lNombreSede.Text = "Nombre Sede";
            // 
            // AdminSedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNombreSede);
            this.Controls.Add(this.listResponsableDeSede);
            this.Controls.Add(this.bQuitarResponsableDeSede);
            this.Controls.Add(this.bAsignarResponsableDeSede);
            this.Controls.Add(this.tResponsableDeSede);
            this.Controls.Add(this.tDisponible);
            this.Controls.Add(this.tAforo);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.lResponsableDeSede);
            this.Controls.Add(this.lDisponible);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.bAsignarCentros);
            this.Controls.Add(this.dataGridView);
            this.Name = "AdminSedeTab";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bAsignarCentros;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.Label lResponsableDeSede;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.TextBox tAforo;
        private System.Windows.Forms.TextBox tDisponible;
        private System.Windows.Forms.TextBox tResponsableDeSede;
        private System.Windows.Forms.Button bAsignarResponsableDeSede;
        private System.Windows.Forms.Button bQuitarResponsableDeSede;
        private System.Windows.Forms.ListBox listResponsableDeSede;
        private System.Windows.Forms.Label lNombreSede;
    }
}