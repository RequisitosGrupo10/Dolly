using BDLibrary;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class DisponibilidadAulas
    {
        private static MySqlBD miBD = new MySqlBD();
        private int idDisponibilidadAulas;
        private int idAula;
        private int responsable;
        private string franja;

        public static List<DisponibilidadAulas> ListaDisponibilidadAulasFranja(Aula aula, string franja)
        {
            List<DisponibilidadAulas> lista = new List<DisponibilidadAulas>();
            string query = "";
            if (aula == null && franja != null)
            {
                //Selecciono todas las asignaciones de aulas en una determinada franja horaria
                query = "SELECT idDisponibilidad FROM DisponibilidadAulas WHERE franja = '" + franja + "';";
            }
            else if (franja == null && aula != null)
            {
                //Selecciono todas las asignaciones de un aula en cualquier franja horaria
                query = "SELECT idDisponibilidad FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + ";";
            }else if (franja == null && aula == null)
            {
                //Selecciono todos los objetos de disponibilidad aulas
                query = "SELECT idDisponibilidad FROM DisponibilidadAulas;";
            }
            else
            {
                //Selecciono la asignación de un aula en una franja horaria determinada
                query= "SELECT idDisponibilidad FROM DisponibilidadAulas WHERE idAula = " + aula.IdAula + ", AND franja = '" + franja + "';";
            }
            foreach (object[] tupla in miBD.Select(query))
            {
                DisponibilidadAulas aux = new DisponibilidadAulas((int)tupla[0]);
                lista.Add(aux);
            }
            return lista;
        }

        public DisponibilidadAulas(int idDisponibilidadAulas)
        {
            try
            {
                object[] tupla = miBD.Select("SELECT idAula, franja, responsable FROM DisponibilidadAulas WHERE idDisponibilidad=" + idDisponibilidadAulas + ";")[0];
                this.idAula = (int)tupla[0];
                this.franja = (string)tupla[1];
                this.responsable= (int)tupla[2];
                this.idDisponibilidadAulas = idDisponibilidadAulas;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public DisponibilidadAulas(string franja, int idAula)
        {
            try
            {
                if (miBD.Select("SELECT nombre FROM DisponibilidadAulas WHERE franja = '" + franja + "' AND idAula = "+idAula+";").Count == 0)
                {
                    miBD.Insert("INSERT INTO DisponibilidadAulas(franja,idAula) VALUES ('" + franja + "', "+idAula+");");
                    Console.WriteLine("Se insertó correctamente");
                    this.idDisponibilidadAulas = (int)miBD.SelectScalar("SELECT MAX(idDisponiblidad) FROM DisponibilidadAulas");
                    this.franja = franja;
                    this.idAula = idAula;
                }
            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        
        
        public int IdDisponibilidadAulas
        {
            get { return idDisponibilidadAulas; }
            //No hay set porque no deberíamos ser capaces de cambiar el id de las aulas
        }

        public int IdAula
        {
            get { return idAula; }
            set {
                try
                {
                    miBD.Update("UPDATE DisponibilidadAulas SET idAula = " + value + " WHERE idDisponiblidad =" + this.idDisponibilidadAulas + ";");
                    idAula = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        public string Franja
        {
            get { return franja; }
            set
            {
                try {
                    miBD.Update("UPDATE DisponibilidadAulas SET franja = '" + value + "' WHERE idDisponiblidad =" + this.idDisponibilidadAulas + ";");
                    franja = value;
                } catch (Exception e) {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        public int Responsable
        {
            get { return responsable; }
            set
            {
                try
                {
                    miBD.Update("UPDATE DisponibilidadAulas SET responsable = " + value + " WHERE idDisponiblidad =" + this.idDisponibilidadAulas + ";");
                    responsable = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }

        public void borrarDisponibilidadAulas()
        {
            miBD.Delete("DELETE FROM DisponibilidadAulas WHERE idDisponiblidad =" + this.idDisponibilidadAulas + ";");
            idDisponibilidadAulas = -1;
            responsable = -1;
            idAula = -1;
            franja = null;
        }

        public override string ToString()
        {
            string res = this.idDisponibilidadAulas + ";" + this.idAula + ";"+this.franja+";"+this.responsable;

            return res;
        }

        public override bool Equals(object obj)
        {
            return obj is DisponibilidadAulas
                && (((DisponibilidadAulas)obj).idAula == this.idAula && ((DisponibilidadAulas)obj).franja.Equals(this.franja));
        }

        public override int GetHashCode()
        {
            return this.franja.GetHashCode()*this.idAula.GetHashCode();
        }
    }

}
