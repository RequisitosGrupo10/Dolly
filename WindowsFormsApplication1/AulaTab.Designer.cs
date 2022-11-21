namespace WindowsFormsApplication1
{
    partial class AulaTab
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
            this.tAula = new System.Windows.Forms.TextBox();
            this.lAforo = new System.Windows.Forms.Label();
            this.tAforo = new System.Windows.Forms.TextBox();
            this.lFranjaHoraria = new System.Windows.Forms.Label();
            this.cbFranjasHorarias = new System.Windows.Forms.CheckedListBox();
            this.bConfirmarCambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lAula
            // 
            this.lAula.AutoSize = true;
            this.lAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lAula.Location = new System.Drawing.Point(283, 41);
            this.lAula.Name = "lAula";
            this.lAula.Size = new System.Drawing.Size(36, 17);
            this.lAula.TabIndex = 0;
            this.lAula.Text = "Aula";
            // 
            // tAula
            // 
            this.tAula.Location = new System.Drawing.Point(325, 38);
            this.tAula.Name = "tAula";
            this.tAula.Size = new System.Drawing.Size(100, 20);
            this.tAula.TabIndex = 1;
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lAforo.Location = new System.Drawing.Point(281, 78);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(42, 17);
            this.lAforo.TabIndex = 2;
            this.lAforo.Text = "Aforo";
            // 
            // tAforo
            // 
            this.tAforo.Location = new System.Drawing.Point(329, 75);
            this.tAforo.Name = "tAforo";
            this.tAforo.Size = new System.Drawing.Size(100, 20);
            this.tAforo.TabIndex = 3;
            // 
            // lFranjaHoraria
            // 
            this.lFranjaHoraria.AutoSize = true;
            this.lFranjaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lFranjaHoraria.Location = new System.Drawing.Point(136, 118);
            this.lFranjaHoraria.Name = "lFranjaHoraria";
            this.lFranjaHoraria.Size = new System.Drawing.Size(185, 17);
            this.lFranjaHoraria.TabIndex = 4;
            this.lFranjaHoraria.Text = "Franja Horaria (seleccionar)";
            // 
            // cbFranjasHorarias
            // 
            this.cbFranjasHorarias.FormattingEnabled = true;
            this.cbFranjasHorarias.Location = new System.Drawing.Point(330, 118);
            this.cbFranjasHorarias.Name = "cbFranjasHorarias";
            this.cbFranjasHorarias.Size = new System.Drawing.Size(339, 289);
            this.cbFranjasHorarias.TabIndex = 5;
            // 
            // bConfirmarCambios
            // 
            this.bConfirmarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bConfirmarCambios.Location = new System.Drawing.Point(174, 299);
            this.bConfirmarCambios.Name = "bConfirmarCambios";
            this.bConfirmarCambios.Size = new System.Drawing.Size(115, 64);
            this.bConfirmarCambios.TabIndex = 6;
            this.bConfirmarCambios.Text = "Confirmar Cambios";
            this.bConfirmarCambios.UseVisualStyleBackColor = true;
            this.bConfirmarCambios.Click += new System.EventHandler(this.bConfirmarCambios_Click);
            // 
            // AulaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConfirmarCambios);
            this.Controls.Add(this.cbFranjasHorarias);
            this.Controls.Add(this.lFranjaHoraria);
            this.Controls.Add(this.tAforo);
            this.Controls.Add(this.lAforo);
            this.Controls.Add(this.tAula);
            this.Controls.Add(this.lAula);
            this.Name = "AulaTab";
            this.Text = "AulaTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAula;
        private System.Windows.Forms.TextBox tAula;
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.TextBox tAforo;
        private System.Windows.Forms.Label lFranjaHoraria;
        private System.Windows.Forms.CheckedListBox cbFranjasHorarias;
        private System.Windows.Forms.Button bConfirmarCambios;
    }
}