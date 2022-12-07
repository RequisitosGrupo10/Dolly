namespace WindowsFormsApplication1
{
    partial class GestionarAulasTab
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
            this.comboFranja = new System.Windows.Forms.ComboBox();
            this.listAforo = new System.Windows.Forms.ListBox();
            this.listResponsable = new System.Windows.Forms.ListBox();
            this.lAforo = new System.Windows.Forms.Label();
            this.lResponsable = new System.Windows.Forms.Label();
            this.dataGridListaAulas = new System.Windows.Forms.DataGridView();
            this.bModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(687, 400);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(61, 21);
            this.bAtras.TabIndex = 4;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // comboFranja
            // 
            this.comboFranja.FormattingEnabled = true;
            this.comboFranja.Location = new System.Drawing.Point(12, 22);
            this.comboFranja.Name = "comboFranja";
            this.comboFranja.Size = new System.Drawing.Size(217, 21);
            this.comboFranja.TabIndex = 5;
            // 
            // listAforo
            // 
            this.listAforo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listAforo.Enabled = false;
            this.listAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAforo.FormattingEnabled = true;
            this.listAforo.ItemHeight = 20;
            this.listAforo.Location = new System.Drawing.Point(520, 98);
            this.listAforo.Name = "listAforo";
            this.listAforo.Size = new System.Drawing.Size(115, 24);
            this.listAforo.TabIndex = 6;
            // 
            // listResponsable
            // 
            this.listResponsable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listResponsable.Enabled = false;
            this.listResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResponsable.FormattingEnabled = true;
            this.listResponsable.ItemHeight = 20;
            this.listResponsable.Location = new System.Drawing.Point(520, 128);
            this.listResponsable.Name = "listResponsable";
            this.listResponsable.Size = new System.Drawing.Size(167, 24);
            this.listResponsable.TabIndex = 7;
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAforo.Location = new System.Drawing.Point(451, 102);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(52, 20);
            this.lAforo.TabIndex = 8;
            this.lAforo.Text = "Aforo:";
            // 
            // lResponsable
            // 
            this.lResponsable.AutoSize = true;
            this.lResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResponsable.Location = new System.Drawing.Point(332, 132);
            this.lResponsable.Name = "lResponsable";
            this.lResponsable.Size = new System.Drawing.Size(171, 20);
            this.lResponsable.TabIndex = 9;
            this.lResponsable.Text = "Responsable de Sede:";
            this.lResponsable.Click += new System.EventHandler(this.lResponsable_Click);
            // 
            // dataGridListaAulas
            // 
            this.dataGridListaAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaAulas.Location = new System.Drawing.Point(285, 180);
            this.dataGridListaAulas.Name = "dataGridListaAulas";
            this.dataGridListaAulas.ReadOnly = true;
            this.dataGridListaAulas.Size = new System.Drawing.Size(456, 207);
            this.dataGridListaAulas.TabIndex = 10;
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bModificar.Enabled = false;
            this.bModificar.Location = new System.Drawing.Point(39, 267);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(207, 44);
            this.bModificar.TabIndex = 11;
            this.bModificar.Text = "Modificar Responsables o Vigilantes";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // GestionarAulasTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.dataGridListaAulas);
            this.Controls.Add(this.lResponsable);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.listResponsable);
            this.Controls.Add(this.listAforo);
            this.Controls.Add(this.comboFranja);
            this.Controls.Add(this.bAtras);
            this.Name = "GestionarAulasTab";
            this.Text = "GestionarAulasTab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.ComboBox comboFranja;
        private System.Windows.Forms.ListBox listAforo;
        private System.Windows.Forms.ListBox listResponsable;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.Label lResponsable;
        private System.Windows.Forms.DataGridView dataGridListaAulas;
        private System.Windows.Forms.Button bModificar;
    }
}