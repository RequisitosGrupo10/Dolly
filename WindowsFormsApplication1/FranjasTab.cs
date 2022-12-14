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
        private int cnt = 0;
        public FranjasTab()
        {
            InitializeComponent();
            Mostrar();
            seleccionado = null;
        }

        private void Mostrar()
        {
            cnt++;
            Console.WriteLine(cnt);
            dataGridView.Rows.Clear();
            List<FranjaHoraria> list = FranjaHoraria.ListarFranjas();
            foreach (FranjaHoraria date in list)
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
                    seleccionado = (FranjaHoraria) dataGridView.SelectedRows[0].Cells[0].Value;      
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
