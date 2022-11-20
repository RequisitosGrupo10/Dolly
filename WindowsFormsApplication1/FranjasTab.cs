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
        private FranjaHoraria seleccionado;
        public FranjasTab()
        {
            InitializeComponent();
            btnInsert.BackColor= SystemColors.Control;
            MostrarFranjas();
            seleccionado = null;
        }

        private void MostrarFranjas()
        {
            dataGridView1.Rows.Clear();
            List<DateTime> list = FranjaHoraria.ListarFranjas();
            foreach (DateTime date in list)
            {
                string dia = date.ToString("dd-MM-yyyy");
                string hora = date.ToString("HH:mm");
                dataGridView1.Rows.Add(new object[] {hora, dia});
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                    var cell = (string) dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (cell != null)
                    {
                        string hora = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string dia = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void toggleButton()
        {
            if (seleccionado != null)
            {
                btnRemove.Enabled = true;
                btnRemove.BackColor = SystemColors.Control;
            }
            else
            {
                btnRemove.Enabled = false;
                btnRemove.BackColor = SystemColors.ControlDark;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                seleccionado.EliminarFranja();
                seleccionado = null;
                toggleButton();
                MostrarFranjas();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddFranjasTab ventana = new AddFranjasTab();
            ventana.ShowDialog();
        }
    }
}
