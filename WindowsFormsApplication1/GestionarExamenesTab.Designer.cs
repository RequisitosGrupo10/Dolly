namespace WindowsFormsApplication1
{
    partial class GestionarExamenesTab
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
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(690, 402);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(61, 21);
            this.bAtras.TabIndex = 4;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // GestionarExamenesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Name = "GestionarExamenesTab";
            this.Text = "GestionarExamenesTab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
    }
}