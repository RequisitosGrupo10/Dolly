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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aforo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.franjas = new System.Windows.Forms.CheckedListBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(283, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aula";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(325, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(281, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aforo";
            // 
            // aforo
            // 
            this.aforo.Location = new System.Drawing.Point(329, 75);
            this.aforo.Name = "aforo";
            this.aforo.Size = new System.Drawing.Size(100, 20);
            this.aforo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(136, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Franja Horaria (seleccionar)";
            // 
            // franjas
            // 
            this.franjas.FormattingEnabled = true;
            this.franjas.Location = new System.Drawing.Point(330, 118);
            this.franjas.Name = "franjas";
            this.franjas.Size = new System.Drawing.Size(339, 289);
            this.franjas.TabIndex = 5;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bConfirmar.Location = new System.Drawing.Point(174, 299);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(115, 64);
            this.bConfirmar.TabIndex = 6;
            this.bConfirmar.Text = "Confirmar Cambios";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // AulaTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.franjas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aforo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "AulaTab";
            this.Text = "AulaTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aforo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox franjas;
        private System.Windows.Forms.Button bConfirmar;
    }
}