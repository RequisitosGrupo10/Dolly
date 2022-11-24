using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Examen
    {
        Asignatura asignatura;
        FranjaHoraria franja;
        public Examen()
        {
            // TODO
            asignatura = null;
        }

        public Examen(Asignatura asignatura)
        {
            this.asignatura = asignatura;
        }

        public override bool Equals(object obj)
        {
            return obj is Examen examen;
        }

        public override int GetHashCode()
        {
            return asignatura.GetHashCode() + franja.GetHashCode();
        }
    }
}
