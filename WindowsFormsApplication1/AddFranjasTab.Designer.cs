using System.Drawing;

namespace WindowsFormsApplication1
{
    partial class AddFranjasTab
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.listHoras = new System.Windows.Forms.ListBox();
            this.lblFranjas = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEliminarAddFranjasTab = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.bAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tInroduceLaHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(58, 60);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // listHoras
            // 
            this.listHoras.FormattingEnabled = true;
            this.listHoras.Location = new System.Drawing.Point(587, 124);
            this.listHoras.Name = "listHoras";
            this.listHoras.Size = new System.Drawing.Size(192, 186);
            this.listHoras.TabIndex = 1;
            this.listHoras.MouseCaptureChanged += new System.EventHandler(this.listHoras_mouseCaptureChanged);
            // 
            // lblFranjas
            // 
            this.lblFranjas.AutoSize = true;
            this.lblFranjas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFranjas.Location = new System.Drawing.Point(583, 61);
            this.lblFranjas.Name = "lblFranjas";
            this.lblFranjas.Size = new System.Drawing.Size(189, 24);
            this.lblFranjas.TabIndex = 2;
            this.lblFranjas.Text = "Horas Seleccionadas";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(310, 199);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Añadir";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bEliminarAddFranjasTab
            // 
            this.bEliminarAddFranjasTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bEliminarAddFranjasTab.Enabled = false;
            this.bEliminarAddFranjasTab.Location = new System.Drawing.Point(472, 199);
            this.bEliminarAddFranjasTab.Name = "bEliminarAddFranjasTab";
            this.bEliminarAddFranjasTab.Size = new System.Drawing.Size(84, 23);
            this.bEliminarAddFranjasTab.TabIndex = 4;
            this.bEliminarAddFranjasTab.Text = "Eliminar";
            this.bEliminarAddFranjasTab.UseVisualStyleBackColor = false;
            this.bEliminarAddFranjasTab.Click += new System.EventHandler(this.bEliminarAddFranjasTab_Click);
            // 
            // bAccept
            // 
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccept.Location = new System.Drawing.Point(634, 337);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(108, 40);
            this.bAccept.TabIndex = 5;
            this.bAccept.Text = "Añadir franjas seleccionadas";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(713, 415);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(75, 23);
            this.bAtras.TabIndex = 6;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduce la hora HH:MM";
            // 
            // tInroduceLaHora
            // 
            this.tInroduceLaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tInroduceLaHora.Location = new System.Drawing.Point(310, 124);
            this.tInroduceLaHora.Name = "tInroduceLaHora";
            this.tInroduceLaHora.Size = new System.Drawing.Size(246, 31);
            this.tInroduceLaHora.TabIndex = 9;
            this.tInroduceLaHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddFranjasTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tInroduceLaHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.bEliminarAddFranjasTab);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lblFranjas);
            this.Controls.Add(this.listHoras);
            this.Controls.Add(this.calendar);
            this.Name = "AddFranjasTab";
            this.Text = "Agregar Franjas Horarias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ListBox listHoras;
        private System.Windows.Forms.Label lblFranjas;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEliminarAddFranjasTab;
        private System.Windows.Forms.Button bAccept;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tInroduceLaHora;
    }
}