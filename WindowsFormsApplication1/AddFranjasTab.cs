using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddFranjasTab : Form
    {
        private string seleccionado;
        public AddFranjasTab()
        {
            InitializeComponent();
            seleccionado = null;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            DateTime day = calendar.SelectionStart;
            String hora = tInroduceLaHora.Text;
            try
            {
                String[] components = hora.Split(':');
                int givenHour = int.Parse(components[0]);
                int givenMinute = int.Parse(components[1]);
                if (components.Length == 2 &&  givenHour >= 0 && givenHour <= 23 && givenMinute >= 0 && givenMinute <= 59) 
                { 
                    StringBuilder sb = new StringBuilder();
                    sb.Append(hora + ", ");
                    sb.Append(day.ToString("dd-MM-yyyy"));
                    listHoras.Items.Add(sb.ToString());
                    tInroduceLaHora.Clear();
                }
                else
                {
                    tInroduceLaHora.Clear();
                    MessageBox.Show("Hora no válida");
                }
            }catch(Exception) 
            {
                tInroduceLaHora.Clear();
                MessageBox.Show("Hora no válida");
            }
        }

        private void bEliminarAddFranjasTab_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                listHoras.Items.Remove(seleccionado);
                seleccionado = null;
                toggleButton();
            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            int count = 0;
            /*foreach (string franjaText in listHoras.Items)
            {
                string date = new FranjaHoraria(franjaText.ToString());
                count++;
            }*/
            MessageBox.Show("Se ha añadido " + count + " franjas horarias en el sistema");
            this.Close();
        }

        private void listHoras_mouseCaptureChanged(object sender, EventArgs e)
        {
            try
            {
                seleccionado = listHoras.SelectedItem.ToString();
            }catch(Exception)
            {

            }
            toggleButton();
        }

        private string ParseToFormat(string selected)
        {
            StringBuilder date = new StringBuilder();
            
            String[] components = Regex.Split(selected, @"\W");

            date.Append(components[5] + "-");
            date.Append(components[4] + "-");
            date.Append(components[3] + " ");
            date.Append(components[0] + ":");
            date.Append(components[1] + ":00");

            return date.ToString();
        }
        private void toggleButton()
        {
            if (seleccionado != null)
            {
                bEliminarAddFranjasTab.Enabled = true;
                bEliminarAddFranjasTab.BackColor = SystemColors.Control;
            }
            else
            {
                bEliminarAddFranjasTab.Enabled = false;
                bEliminarAddFranjasTab.BackColor = SystemColors.ControlDark;
            }
        }
   
    }
}
