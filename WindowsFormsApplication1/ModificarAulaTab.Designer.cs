﻿namespace WindowsFormsApplication1
{
    partial class ModificarAulaTab
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
            this.lAula = new System.Windows.Forms.Label();
            this.listResponsable = new System.Windows.Forms.ListBox();
            this.lResponsable = new System.Windows.Forms.Label();
            this.listFranja = new System.Windows.Forms.ListBox();
            this.listProfesores = new System.Windows.Forms.ListBox();
            this.bAsignarResponsable = new System.Windows.Forms.Button();
            this.bEliminarResponsable = new System.Windows.Forms.Button();
            this.bAsignarVigilante = new System.Windows.Forms.Button();
            this.bEliminarVigilante = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.lProfesoresDisponibles = new System.Windows.Forms.Label();
            this.dataGridVigilantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVigilantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lAula
            // 
            this.lAula.AutoSize = true;
            this.lAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAula.Location = new System.Drawing.Point(132, 45);
            this.lAula.Name = "lAula";
            this.lAula.Size = new System.Drawing.Size(60, 25);
            this.lAula.TabIndex = 0;
            this.lAula.Text = "lAula";
            // 
            // listResponsable
            // 
            this.listResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResponsable.FormattingEnabled = true;
            this.listResponsable.ItemHeight = 20;
            this.listResponsable.Location = new System.Drawing.Point(496, 66);
            this.listResponsable.Name = "listResponsable";
            this.listResponsable.Size = new System.Drawing.Size(267, 24);
            this.listResponsable.TabIndex = 1;
            // 
            // lResponsable
            // 
            this.lResponsable.AutoSize = true;
            this.lResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResponsable.Location = new System.Drawing.Point(322, 70);
            this.lResponsable.Name = "lResponsable";
            this.lResponsable.Size = new System.Drawing.Size(168, 20);
            this.lResponsable.TabIndex = 2;
            this.lResponsable.Text = "Responsable De Aula:";
            // 
            // listFranja
            // 
            this.listFranja.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listFranja.Enabled = false;
            this.listFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFranja.FormattingEnabled = true;
            this.listFranja.ItemHeight = 20;
            this.listFranja.Location = new System.Drawing.Point(496, 12);
            this.listFranja.Name = "listFranja";
            this.listFranja.Size = new System.Drawing.Size(267, 24);
            this.listFranja.TabIndex = 3;
            // 
            // listProfesores
            // 
            this.listProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProfesores.FormattingEnabled = true;
            this.listProfesores.ItemHeight = 20;
            this.listProfesores.Location = new System.Drawing.Point(23, 305);
            this.listProfesores.Name = "listProfesores";
            this.listProfesores.Size = new System.Drawing.Size(276, 124);
            this.listProfesores.TabIndex = 4;
            // 
            // bAsignarResponsable
            // 
            this.bAsignarResponsable.Location = new System.Drawing.Point(23, 129);
            this.bAsignarResponsable.Name = "bAsignarResponsable";
            this.bAsignarResponsable.Size = new System.Drawing.Size(135, 41);
            this.bAsignarResponsable.TabIndex = 5;
            this.bAsignarResponsable.Text = "Asignar Responsable";
            this.bAsignarResponsable.UseVisualStyleBackColor = true;
            // 
            // bEliminarResponsable
            // 
            this.bEliminarResponsable.Location = new System.Drawing.Point(164, 129);
            this.bEliminarResponsable.Name = "bEliminarResponsable";
            this.bEliminarResponsable.Size = new System.Drawing.Size(135, 41);
            this.bEliminarResponsable.TabIndex = 6;
            this.bEliminarResponsable.Text = "Eliminar Responsable";
            this.bEliminarResponsable.UseVisualStyleBackColor = true;
            // 
            // bAsignarVigilante
            // 
            this.bAsignarVigilante.Location = new System.Drawing.Point(23, 176);
            this.bAsignarVigilante.Name = "bAsignarVigilante";
            this.bAsignarVigilante.Size = new System.Drawing.Size(135, 41);
            this.bAsignarVigilante.TabIndex = 7;
            this.bAsignarVigilante.Text = "Asignar Vigilante";
            this.bAsignarVigilante.UseVisualStyleBackColor = true;
            // 
            // bEliminarVigilante
            // 
            this.bEliminarVigilante.Location = new System.Drawing.Point(164, 176);
            this.bEliminarVigilante.Name = "bEliminarVigilante";
            this.bEliminarVigilante.Size = new System.Drawing.Size(135, 41);
            this.bEliminarVigilante.TabIndex = 8;
            this.bEliminarVigilante.Text = "Eliminar Vigilante";
            this.bEliminarVigilante.UseVisualStyleBackColor = true;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(90, 223);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(142, 41);
            this.bConfirmar.TabIndex = 9;
            this.bConfirmar.Text = "Confirmar Cambios";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // lProfesoresDisponibles
            // 
            this.lProfesoresDisponibles.AutoSize = true;
            this.lProfesoresDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesoresDisponibles.Location = new System.Drawing.Point(67, 282);
            this.lProfesoresDisponibles.Name = "lProfesoresDisponibles";
            this.lProfesoresDisponibles.Size = new System.Drawing.Size(176, 20);
            this.lProfesoresDisponibles.TabIndex = 10;
            this.lProfesoresDisponibles.Text = "Profesores Disponibles:";
            // 
            // dataGridVigilantes
            // 
            this.dataGridVigilantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVigilantes.Location = new System.Drawing.Point(326, 129);
            this.dataGridVigilantes.Name = "dataGridVigilantes";
            this.dataGridVigilantes.Size = new System.Drawing.Size(437, 299);
            this.dataGridVigilantes.TabIndex = 11;
            // 
            // ModificarAulaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridVigilantes);
            this.Controls.Add(this.lProfesoresDisponibles);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.bEliminarVigilante);
            this.Controls.Add(this.bAsignarVigilante);
            this.Controls.Add(this.bEliminarResponsable);
            this.Controls.Add(this.bAsignarResponsable);
            this.Controls.Add(this.listProfesores);
            this.Controls.Add(this.listFranja);
            this.Controls.Add(this.lResponsable);
            this.Controls.Add(this.listResponsable);
            this.Controls.Add(this.lAula);
            this.Name = "ModificarAulaTab";
            this.Text = "ModificarAulaTab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVigilantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAula;
        private System.Windows.Forms.ListBox listResponsable;
        private System.Windows.Forms.Label lResponsable;
        private System.Windows.Forms.ListBox listFranja;
        private System.Windows.Forms.ListBox listProfesores;
        private System.Windows.Forms.Button bAsignarResponsable;
        private System.Windows.Forms.Button bEliminarResponsable;
        private System.Windows.Forms.Button bAsignarVigilante;
        private System.Windows.Forms.Button bEliminarVigilante;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label lProfesoresDisponibles;
        private System.Windows.Forms.DataGridView dataGridVigilantes;
    }
}