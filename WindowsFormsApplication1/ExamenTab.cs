using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Parser;

namespace WindowsFormsApplication1
{
    public partial class ExamenTab : Form
    {
        public ExamenTab()
        {
            InitializeComponent();
            MostrarExamenes();
        }

        private void MostrarExamenes()
        {
            dataGridView1.DataSource = Examen.ListaExamenes();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bImportar_Click(object sender, EventArgs e)
        {
            CSVParser parser = new CSVParser(new ExamenStrategy());
            parser.Parse();
            MostrarExamenes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int len = dataGridView1.SelectedRows.Count;
                    for (int i = 0; i < len; i++)
                    { 
                    
                        Examen seleccionado =  new Examen (Int32.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()));
                        seleccionado.BorrarExamen();
                    }
                    MostrarExamenes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
