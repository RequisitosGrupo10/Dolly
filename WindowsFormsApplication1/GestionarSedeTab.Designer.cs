namespace WindowsFormsApplication1
{
    partial class GestionarSedeTab
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
            this.lNombreSede = new System.Windows.Forms.Label();
            this.lAforo = new System.Windows.Forms.Label();
            this.tAforo = new System.Windows.Forms.TextBox();
            this.lDisponible = new System.Windows.Forms.Label();
            this.tDisponible = new System.Windows.Forms.TextBox();
            this.lResponsableDeSede = new System.Windows.Forms.Label();
            this.tResponsableDeSede = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bInsertarAula = new System.Windows.Forms.Button();
            this.bModificarAula = new System.Windows.Forms.Button();
            this.bEliminarAula = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombreSede
            // 
            this.lNombreSede.AutoSize = true;
            this.lNombreSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreSede.Location = new System.Drawing.Point(22, 26);
            this.lNombreSede.Name = "lNombreSede";
            this.lNombreSede.Size = new System.Drawing.Size(118, 20);
            this.lNombreSede.TabIndex = 17;
            this.lNombreSede.Text = "Nombre Sede";
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Location = new System.Drawing.Point(363, 38);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(32, 13);
            this.lAforo.TabIndex = 18;
            this.lAforo.Text = "Aforo";
            // 
            // tAforo
            // 
            this.tAforo.Location = new System.Drawing.Point(419, 32);
            this.tAforo.Name = "tAforo";
            this.tAforo.Size = new System.Drawing.Size(100, 20);
            this.tAforo.TabIndex = 19;
            // 
            // lDisponible
            // 
            this.lDisponible.AutoSize = true;
            this.lDisponible.Location = new System.Drawing.Point(560, 38);
            this.lDisponible.Name = "lDisponible";
            this.lDisponible.Size = new System.Drawing.Size(56, 13);
            this.lDisponible.TabIndex = 20;
            this.lDisponible.Text = "Disponible";
            // 
            // tDisponible
            // 
            this.tDisponible.Location = new System.Drawing.Point(631, 32);
            this.tDisponible.Name = "tDisponible";
            this.tDisponible.Size = new System.Drawing.Size(100, 20);
            this.tDisponible.TabIndex = 21;
            // 
            // lResponsableDeSede
            // 
            this.lResponsableDeSede.AutoSize = true;
            this.lResponsableDeSede.Location = new System.Drawing.Point(283, 74);
            this.lResponsableDeSede.Name = "lResponsableDeSede";
            this.lResponsableDeSede.Size = new System.Drawing.Size(112, 13);
            this.lResponsableDeSede.TabIndex = 22;
            this.lResponsableDeSede.Text = "Responsable de Sede";
            // 
            // tResponsableDeSede
            // 
            this.tResponsableDeSede.Location = new System.Drawing.Point(419, 71);
            this.tResponsableDeSede.Name = "tResponsableDeSede";
            this.tResponsableDeSede.Size = new System.Drawing.Size(192, 20);
            this.tResponsableDeSede.TabIndex = 23;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(333, 114);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(422, 289);
            this.dataGridView.TabIndex = 24;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // bInsertarAula
            // 
            this.bInsertarAula.Location = new System.Drawing.Point(11, 161);
            this.bInsertarAula.Margin = new System.Windows.Forms.Padding(2);
            this.bInsertarAula.Name = "bInsertarAula";
            this.bInsertarAula.Size = new System.Drawing.Size(297, 41);
            this.bInsertarAula.TabIndex = 25;
            this.bInsertarAula.Text = "Insertar Aula";
            this.bInsertarAula.UseVisualStyleBackColor = true;
            this.bInsertarAula.Click += new System.EventHandler(this.bInsertarAula_Click);
            // 
            // bModificarAula
            // 
            this.bModificarAula.Location = new System.Drawing.Point(11, 241);
            this.bModificarAula.Margin = new System.Windows.Forms.Padding(2);
            this.bModificarAula.Name = "bModificarAula";
            this.bModificarAula.Size = new System.Drawing.Size(297, 41);
            this.bModificarAula.TabIndex = 26;
            this.bModificarAula.Text = "Modificar Aula";
            this.bModificarAula.UseVisualStyleBackColor = true;
            this.bModificarAula.Click += new System.EventHandler(this.bModificarAula_Click);
            // 
            // bEliminarAula
            // 
            this.bEliminarAula.Location = new System.Drawing.Point(11, 323);
            this.bEliminarAula.Margin = new System.Windows.Forms.Padding(2);
            this.bEliminarAula.Name = "bEliminarAula";
            this.bEliminarAula.Size = new System.Drawing.Size(297, 41);
            this.bEliminarAula.TabIndex = 27;
            this.bEliminarAula.Text = "Eliminar Aula";
            this.bEliminarAula.UseVisualStyleBackColor = true;
            this.bEliminarAula.Click += new System.EventHandler(this.bEliminarAula_Click);
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(699, 420);
            this.bAtras.Margin = new System.Windows.Forms.Padding(2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(56, 19);
            this.bAtras.TabIndex = 28;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // GestionarSedeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bEliminarAula);
            this.Controls.Add(this.bModificarAula);
            this.Controls.Add(this.bInsertarAula);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tResponsableDeSede);
            this.Controls.Add(this.lResponsableDeSede);
            this.Controls.Add(this.tDisponible);
            this.Controls.Add(this.lDisponible);
            this.Controls.Add(this.tAforo);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.lNombreSede);
            this.Name = "GestionarSedeTab";
            this.Text = "Gestionar Sede";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombreSede;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.TextBox tAforo;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.TextBox tDisponible;
        private System.Windows.Forms.Label lResponsableDeSede;
        private System.Windows.Forms.TextBox tResponsableDeSede;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bInsertarAula;
        private System.Windows.Forms.Button bModificarAula;
        private System.Windows.Forms.Button bEliminarAula;
        private System.Windows.Forms.Button bAtras;
    }
}