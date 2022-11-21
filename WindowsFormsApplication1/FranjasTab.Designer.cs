using System.Drawing;

namespace WindowsFormsApplication1
{
    partial class FranjasTab
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
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bInsertarFranjaHoraria = new System.Windows.Forms.Button();
            this.bEliminarFranjaHoraria = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Dia});
            this.dataGridView.Location = new System.Drawing.Point(161, 44);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(469, 214);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // bInsertarFranjaHoraria
            // 
            this.bInsertarFranjaHoraria.BackColor = System.Drawing.SystemColors.Control;
            this.bInsertarFranjaHoraria.Location = new System.Drawing.Point(276, 299);
            this.bInsertarFranjaHoraria.Name = "bInsertarFranjaHoraria";
            this.bInsertarFranjaHoraria.Size = new System.Drawing.Size(237, 48);
            this.bInsertarFranjaHoraria.TabIndex = 1;
            this.bInsertarFranjaHoraria.Text = "Insertar Franja Horaria";
            this.bInsertarFranjaHoraria.UseVisualStyleBackColor = false;
            this.bInsertarFranjaHoraria.Click += new System.EventHandler(this.bInsertarFranjaHoraria_Click);
            // 
            // bEliminarFranjaHoraria
            // 
            this.bEliminarFranjaHoraria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bEliminarFranjaHoraria.Location = new System.Drawing.Point(276, 371);
            this.bEliminarFranjaHoraria.Name = "bEliminarFranjaHoraria";
            this.bEliminarFranjaHoraria.Size = new System.Drawing.Size(233, 48);
            this.bEliminarFranjaHoraria.TabIndex = 2;
            this.bEliminarFranjaHoraria.Text = "Eliminar Franja Horaria";
            this.bEliminarFranjaHoraria.UseVisualStyleBackColor = false;
            this.bEliminarFranjaHoraria.Click += new System.EventHandler(this.bEliminarFranjaHoraria_Click);
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(716, 398);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(61, 21);
            this.bAtras.TabIndex = 3;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // FranjasTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bEliminarFranjaHoraria);
            this.Controls.Add(this.bInsertarFranjaHoraria);
            this.Controls.Add(this.dataGridView);
            this.Name = "FranjasTab";
            this.Text = "Franjas Horarias";
            this.Activated += new System.EventHandler(this.vActualizar_FocusGain);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bInsertarFranjaHoraria;
        private System.Windows.Forms.Button bEliminarFranjaHoraria;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
    }
}