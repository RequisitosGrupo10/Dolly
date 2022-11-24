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
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Dia});
            this.dataGridView.Location = new System.Drawing.Point(215, 54);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(625, 263);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // bInsertarFranjaHoraria
            // 
            this.bInsertarFranjaHoraria.BackColor = System.Drawing.SystemColors.Control;
            this.bInsertarFranjaHoraria.Location = new System.Drawing.Point(368, 368);
            this.bInsertarFranjaHoraria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bInsertarFranjaHoraria.Name = "bInsertarFranjaHoraria";
            this.bInsertarFranjaHoraria.Size = new System.Drawing.Size(316, 59);
            this.bInsertarFranjaHoraria.TabIndex = 1;
            this.bInsertarFranjaHoraria.Text = "Insertar Franja Horaria";
            this.bInsertarFranjaHoraria.UseVisualStyleBackColor = false;
            this.bInsertarFranjaHoraria.Click += new System.EventHandler(this.bInsertarFranjaHoraria_Click);
            // 
            // bEliminarFranjaHoraria
            // 
            this.bEliminarFranjaHoraria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bEliminarFranjaHoraria.Location = new System.Drawing.Point(368, 457);
            this.bEliminarFranjaHoraria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEliminarFranjaHoraria.Name = "bEliminarFranjaHoraria";
            this.bEliminarFranjaHoraria.Size = new System.Drawing.Size(311, 59);
            this.bEliminarFranjaHoraria.TabIndex = 2;
            this.bEliminarFranjaHoraria.Text = "Eliminar Franja Horaria";
            this.bEliminarFranjaHoraria.UseVisualStyleBackColor = false;
            this.bEliminarFranjaHoraria.Click += new System.EventHandler(this.bEliminarFranjaHoraria_Click);
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(955, 490);
            this.bAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(81, 26);
            this.bAtras.TabIndex = 3;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // FranjasTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bEliminarFranjaHoraria);
            this.Controls.Add(this.bInsertarFranjaHoraria);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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