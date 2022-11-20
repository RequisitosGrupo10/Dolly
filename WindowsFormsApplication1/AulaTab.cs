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
            name.Text = aula.Nombre;
            aforo.Text = aula.Aforo.ToString();
            MySqlBD miBD = new MySqlBD();

            List<Object[]> dates = miBD.Select("SELECT franja FROM FranjaHoraria");
            List<DateTime> datesAssigned = Aula.DisponibilidadHorarias(aula);
            foreach (Object[] date in dates)
            {
                franjas.Items.Add((DateTime)date[0]);
                if (datesAssigned.Contains((DateTime)date[0]))
                {
                    franjas.SetItemChecked(franjas.Items.Count, true);
                }
            }
            

        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if (aula.Nombre == null)
            {
                aula.Nombre = name.Text;
            }
            else if (!aula.Nombre.Equals(name.Text))
            {
                aula.Nombre = name.Text;
            }

            
            if (aula.Aforo != int.Parse(aforo.Text))
            {
                aula.Aforo = int.Parse(aforo.Text);
            }
            
        }
    }
}
