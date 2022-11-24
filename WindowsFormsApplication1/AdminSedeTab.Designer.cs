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
            this.bAsignarCentro = new System.Windows.Forms.Button();
            this.bQuitarCentro = new System.Windows.Forms.Button();
            this.listCentros = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(451, 128);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(563, 356);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Location = new System.Drawing.Point(513, 37);
            this.lAforo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(39, 16);
            this.lAforo.TabIndex = 5;
            this.lAforo.Text = "Aforo";
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Location = new System.Drawing.Point(757, 37);
            this.lDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(72, 16);
            this.lDisponible.TabIndex = 6;
            this.lDisponible.Text = "Disponible";
            // 
            // lResponsableDeSede
            // 
            this.lResponsableDeSede.AutoSize = true;
            this.lResponsableDeSede.Location = new System.Drawing.Point(407, 87);
            this.lResponsableDeSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResponsableDeSede.Name = "lResponsableDeSede";
            this.lResponsableDeSede.Size = new System.Drawing.Size(144, 16);
            this.lResponsableDeSede.TabIndex = 7;
            this.lResponsableDeSede.Text = "Responsable de Sede";
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(916, 505);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 8;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // tAforo
            // 
            this.tAforo.Location = new System.Drawing.Point(576, 33);
            this.tAforo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tAforo.Name = "tAforo";
            this.tAforo.Size = new System.Drawing.Size(132, 22);
            this.tAforo.TabIndex = 9;
            // 
            // tDisponible
            // 
            this.tDisponible.Location = new System.Drawing.Point(857, 33);
            this.tDisponible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDisponible.Name = "tDisponible";
            this.tDisponible.Size = new System.Drawing.Size(132, 22);
            this.tDisponible.TabIndex = 10;
            // 
            // tResponsableDeSede
            // 
            this.tResponsableDeSede.Location = new System.Drawing.Point(576, 84);
            this.tResponsableDeSede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tResponsableDeSede.Name = "tResponsableDeSede";
            this.tResponsableDeSede.Size = new System.Drawing.Size(255, 22);
            this.tResponsableDeSede.TabIndex = 11;
            // 
            // bAsignarResponsableDeSede
            // 
            this.bAsignarResponsableDeSede.Location = new System.Drawing.Point(31, 128);
            this.bAsignarResponsableDeSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAsignarResponsableDeSede.Name = "bAsignarResponsableDeSede";
            this.bAsignarResponsableDeSede.Size = new System.Drawing.Size(177, 50);
            this.bAsignarResponsableDeSede.TabIndex = 13;
            this.bAsignarResponsableDeSede.Text = "Asignar Responsable de Sede";
            this.bAsignarResponsableDeSede.UseVisualStyleBackColor = true;
            this.bAsignarResponsableDeSede.Click += new System.EventHandler(this.bAsignarResponsableDeSede_Click);
            // 
            // bQuitarResponsableDeSede
            // 
            this.bQuitarResponsableDeSede.Location = new System.Drawing.Point(237, 128);
            this.bQuitarResponsableDeSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bQuitarResponsableDeSede.Name = "bQuitarResponsableDeSede";
            this.bQuitarResponsableDeSede.Size = new System.Drawing.Size(176, 50);
            this.bQuitarResponsableDeSede.TabIndex = 14;
            this.bQuitarResponsableDeSede.Text = "Quitar Responsable de Sede";
            this.bQuitarResponsableDeSede.UseVisualStyleBackColor = true;
            this.bQuitarResponsableDeSede.Click += new System.EventHandler(this.bQuitarResponsableDeSede_Click);
            // 
            // listResponsableDeSede
            // 
            this.listResponsableDeSede.FormattingEnabled = true;
            this.listResponsableDeSede.ItemHeight = 16;
            this.listResponsableDeSede.Location = new System.Drawing.Point(56, 197);
            this.listResponsableDeSede.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listResponsableDeSede.Name = "listResponsableDeSede";
            this.listResponsableDeSede.Size = new System.Drawing.Size(333, 100);
            this.listResponsableDeSede.TabIndex = 15;
            this.listResponsableDeSede.SelectedIndexChanged += new System.EventHandler(this.lResponsableDeSede_SelectedIndexChanged);
            // 
            // lNombreSede
            // 
            this.lNombreSede.AutoSize = true;
            this.lNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSede.Location = new System.Drawing.Point(27, 33);
            this.lNombreSede.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreSede.Name = "lNombreSede";
            this.lNombreSede.Size = new System.Drawing.Size(144, 25);
            this.lNombreSede.TabIndex = 16;
            this.lNombreSede.Text = "Nombre Sede";
            // 
            // bAsignarCentro
            // 
            this.bAsignarCentro.Location = new System.Drawing.Point(31, 335);
            this.bAsignarCentro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAsignarCentro.Name = "bAsignarCentro";
            this.bAsignarCentro.Size = new System.Drawing.Size(176, 49);
            this.bAsignarCentro.TabIndex = 19;
            this.bAsignarCentro.Text = "Asignar Centro";
            this.bAsignarCentro.UseVisualStyleBackColor = true;
            this.bAsignarCentro.Click += new System.EventHandler(this.bAsignarCentro_Click);
            // 
            // bQuitarCentro
            // 
            this.bQuitarCentro.Location = new System.Drawing.Point(237, 335);
            this.bQuitarCentro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bQuitarCentro.Name = "bQuitarCentro";
            this.bQuitarCentro.Size = new System.Drawing.Size(176, 49);
            this.bQuitarCentro.TabIndex = 20;
            this.bQuitarCentro.Text = "Quitar Centro";
            this.bQuitarCentro.UseVisualStyleBackColor = true;
            this.bQuitarCentro.Click += new System.EventHandler(this.bQuitarCentro_Click);
            // 
            // listCentros
            // 
            this.listCentros.FormattingEnabled = true;
            this.listCentros.ItemHeight = 16;
            this.listCentros.Location = new System.Drawing.Point(56, 401);
            this.listCentros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listCentros.Name = "listCentros";
            this.listCentros.Size = new System.Drawing.Size(333, 100);
            this.listCentros.TabIndex = 21;
            this.listCentros.SelectedIndexChanged += new System.EventHandler(this.listCentros_SelectedIndexChanged);
            // 
            // AdminSedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listCentros);
            this.Controls.Add(this.bQuitarCentro);
            this.Controls.Add(this.bAsignarCentro);
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
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSedeTab";
            this.Text = "Gestionar Sede";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
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
        private System.Windows.Forms.Button bAsignarCentro;
        private System.Windows.Forms.Button bQuitarCentro;
        private System.Windows.Forms.ListBox listCentros;
    }
}