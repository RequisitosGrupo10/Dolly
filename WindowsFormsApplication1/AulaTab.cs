using BDLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AulaTab : Form
    {
        private Aula aula;
        public AulaTab(Aula aula)
        {
            this.aula = aula;
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            tAula.Text = aula.Nombre;
            tAforo.Text = aula.Aforo.ToString();
            
            List<string> dates = FranjaHoraria.ListarFranjas();
            List<string> datesAssigned = Aula.DisponibilidadHorarias(aula);
            foreach (string date in dates)
            {
                cbFranjasHorarias.Items.Add(date);
                if (datesAssigned.Contains(date))
                {
                    cbFranjasHorarias.SetItemChecked(cbFranjasHorarias.Items.Count-1, true);
                }
            }
        }

        private void bConfirmarCambios_Click(object sender, EventArgs e)
        {
            if (aula.Nombre == null)
            {
                aula.Nombre = tAula.Text;
                
            }
            else if (!aula.Nombre.Equals(tAula.Text))
            {
                aula.Nombre = tAula.Text;
            }


            if (aula.Aforo != int.Parse(tAforo.Text))
            {
                aula.Aforo = int.Parse(tAforo.Text);
            }


            List<String> dates = FranjaHoraria.ListarFranjas();
            MySqlBD myBD = new MySqlBD();
            foreach (string date in dates)
            {
                if (cbFranjasHorarias.CheckedItems.Contains(date))
                {
                    myBD.Insert("INSERT INTO DisponibilidadAulas VALUES (" + aula.IdAula + ", '" + date + "' )");
                }
                else
                {
                    myBD.Delete("DELETE FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + " AND franja = '" + date + "';");
                }
            }

            cbFranjasHorarias.Items.Clear();
            this.Close();
        }
    }
}
