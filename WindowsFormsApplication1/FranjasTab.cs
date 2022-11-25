using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FranjasTab : Form
    {
        //FALTA HACER EL INSERTAR FRANJA HORARIA
        private FranjaHoraria seleccionado;
        public FranjasTab()
        {
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            dataGridView.Rows.Clear();
            List<string> list = FranjaHoraria.ListarFranjas();
            foreach (string date in list)
            {
                dataGridView.Rows.Add(date);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {

                    var cell = (string)dataGridView.SelectedRows[0].Cells[0].Value;
                    if (cell != null)
                    {
                        string hora = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                        string dia = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        string s = dia + ":" + hora;
                        seleccionado = new FranjaHoraria(s);
                    }
                    else
                    {
                        seleccionado = null;
                    }

                }
                toggleButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bEliminarFranjaHoraria_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.EliminarFranja();
                seleccionado = null;
                toggleButton();
                Mostrar();
            }
        }

        private void toggleButton()
        {
            if (seleccionado != null)
            {
                bEliminarFranjaHoraria.Enabled = true;
                bEliminarFranjaHoraria.BackColor = SystemColors.Control;
            }
            else
            {
                bEliminarFranjaHoraria.Enabled = false;
                bEliminarFranjaHoraria.BackColor = SystemColors.ControlDark;
            }
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bInsertarFranjaHoraria_Click(object sender, EventArgs e)
        {
            AddFranjasTab ventana = new AddFranjasTab();
            ventana.ShowDialog();
        }

        private void vActualizar_FocusGain(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
