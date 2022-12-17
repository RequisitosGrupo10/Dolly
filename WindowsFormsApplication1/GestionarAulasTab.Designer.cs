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
            this.lAforo = new System.Windows.Forms.Label();
            this.lResponsable = new System.Windows.Forms.Label();
            this.dataGridListaAulas = new System.Windows.Forms.DataGridView();
            this.bModificar = new System.Windows.Forms.Button();
            this.textAforo = new System.Windows.Forms.TextBox();
            this.textResponsable = new System.Windows.Forms.TextBox();
            this.lFranjaSeleccionada = new System.Windows.Forms.Label();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aforo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsabledeAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(709, 405);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(61, 21);
            this.bAtras.TabIndex = 4;
            this.bAtras.Text = "ATRÁS";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // comboFranja
            // 
            this.comboFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFranja.FormattingEnabled = true;
            this.comboFranja.Location = new System.Drawing.Point(12, 21);
            this.comboFranja.Name = "comboFranja";
            this.comboFranja.Size = new System.Drawing.Size(300, 28);
            this.comboFranja.TabIndex = 5;
            this.comboFranja.SelectedIndexChanged += new System.EventHandler(this.comboFranja_SelectedIndexChanged);
            // 
            // lAforo
            // 
            this.lAforo.AutoSize = true;
            this.lAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAforo.Location = new System.Drawing.Point(437, 58);
            this.lAforo.Name = "lAforo";
            this.lAforo.Size = new System.Drawing.Size(52, 20);
            this.lAforo.TabIndex = 8;
            this.lAforo.Text = "Aforo:";
            // 
            // lResponsable
            // 
            this.lResponsable.AutoSize = true;
            this.lResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResponsable.Location = new System.Drawing.Point(318, 88);
            this.lResponsable.Name = "lResponsable";
            this.lResponsable.Size = new System.Drawing.Size(171, 20);
            this.lResponsable.TabIndex = 9;
            this.lResponsable.Text = "Responsable de Sede:";
            // 
            // dataGridListaAulas
            // 
            this.dataGridListaAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListaAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aula,
            this.Aforo,
            this.ResponsabledeAula});
            this.dataGridListaAulas.Location = new System.Drawing.Point(188, 180);
            this.dataGridListaAulas.MultiSelect = false;
            this.dataGridListaAulas.Name = "dataGridListaAulas";
            this.dataGridListaAulas.ReadOnly = true;
            this.dataGridListaAulas.Size = new System.Drawing.Size(582, 207);
            this.dataGridListaAulas.TabIndex = 10;
            this.dataGridListaAulas.SelectionChanged += new System.EventHandler(this.dataGridListaAulas_SelectionChanged);
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bModificar.Enabled = false;
            this.bModificar.Location = new System.Drawing.Point(12, 268);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(155, 44);
            this.bModificar.TabIndex = 11;
            this.bModificar.Text = "Modificar Responsables o Vigilantes";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // textAforo
            // 
            this.textAforo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textAforo.Enabled = false;
            this.textAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAforo.Location = new System.Drawing.Point(506, 52);
            this.textAforo.Name = "textAforo";
            this.textAforo.Size = new System.Drawing.Size(115, 26);
            this.textAforo.TabIndex = 12;
            // 
            // textResponsable
            // 
            this.textResponsable.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textResponsable.Enabled = false;
            this.textResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponsable.Location = new System.Drawing.Point(506, 82);
            this.textResponsable.Name = "textResponsable";
            this.textResponsable.Size = new System.Drawing.Size(167, 26);
            this.textResponsable.TabIndex = 13;
            // 
            // lFranjaSeleccionada
            // 
            this.lFranjaSeleccionada.AutoSize = true;
            this.lFranjaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFranjaSeleccionada.Location = new System.Drawing.Point(367, 139);
            this.lFranjaSeleccionada.Name = "lFranjaSeleccionada";
            this.lFranjaSeleccionada.Size = new System.Drawing.Size(0, 20);
            this.lFranjaSeleccionada.TabIndex = 14;
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // Aforo
            // 
            this.Aforo.HeaderText = "Aforo";
            this.Aforo.Name = "Aforo";
            this.Aforo.ReadOnly = true;
            // 
            // ResponsabledeAula
            // 
            this.ResponsabledeAula.HeaderText = "ResponsabledeAula";
            this.ResponsabledeAula.Name = "ResponsabledeAula";
            this.ResponsabledeAula.ReadOnly = true;
            // 
            // GestionarAulasTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lFranjaSeleccionada);
            this.Controls.Add(this.textResponsable);
            this.Controls.Add(this.textAforo);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.dataGridListaAulas);
            this.Controls.Add(this.lResponsable);
            this.Controls.Add(this.lAforo);
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
        private System.Windows.Forms.Label lAforo;
        private System.Windows.Forms.Label lResponsable;
        private System.Windows.Forms.DataGridView dataGridListaAulas;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.TextBox textAforo;
        private System.Windows.Forms.TextBox textResponsable;
        private System.Windows.Forms.Label lFranjaSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aforo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsabledeAula;
    }
}