using BDLibrary;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
            
            List<FranjaHoraria> dates = FranjaHoraria.ListarFranjas();
            List<string> datesAssigned = Aula.DisponibilidadHorarias(aula);
            foreach (FranjaHoraria date in dates)
            {
                cbFranjasHorarias.Items.Add(date);
                if (datesAssigned.Contains(date.ToString()))
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


            List<FranjaHoraria> dates = FranjaHoraria.ListarFranjas();
            MySqlBD myBD = new MySqlBD();
            foreach (FranjaHoraria date in dates)
            {
                if (cbFranjasHorarias.CheckedItems.Contains(date))
                {
                    try
                    {
                        myBD.Insert("INSERT INTO DisponibilidadAulas (idAula,franja) VALUES (" + aula.IdAula + ", '" + date.ToString() + "' )");
                    }
                    catch (DbException)
                    {
                        Console.WriteLine("Error found");
                    }
                    
                }
                else
                {
                    myBD.Delete("DELETE FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + " AND franja = '" + date.ToString() + "';");
                }
            }

            cbFranjasHorarias.Items.Clear();
            this.Close();
        }
    }
}
