﻿using BDLibrary;
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
            
            List<DateTime> dates = FranjaHoraria.ListarFranjas();
            List<DateTime> datesAssigned = Aula.DisponibilidadHorarias(aula);
            foreach (DateTime date in dates)
            {
                franjas.Items.Add(date);
                if (datesAssigned.Contains(date))
                {
                    franjas.SetItemChecked(franjas.Items.Count-1, true);
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

            
            List<DateTime> dates = FranjaHoraria.ListarFranjas();
            MySqlBD myBD = new MySqlBD();
            foreach (DateTime date in dates)
            {
                if (franjas.CheckedItems.Contains(date))
                {
                    myBD.Insert("INSERT INTO DisponibilidadAulas VALUES (" + aula.IdAula + ", '" + FranjaHoraria.toSQLFormat(date) + "' )");
                }
                else
                {
                    myBD.Delete("DELETE FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + " AND franja = '" + FranjaHoraria.toSQLFormat(date) + "';");
                }
            }

            franjas.Items.Clear();
            Mostrar();
            
        }
    }
}
