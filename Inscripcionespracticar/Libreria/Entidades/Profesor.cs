using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class Profesor: Persona
    {
        private int _legajo;

        

        public Profesor(int legajo, string nombre, string apellido): base(nombre, apellido)
        {
            Legajo = legajo;
        }
        public Profesor()
        {
            
        }

        public int Legajo { get => _legajo; set => _legajo = value; }

        internal override string Mostrar()
        {
            return $"{this.Apellido}-{this.Legajo}";
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Profesor))
                return false;
            Profesor inscripcionaacomparar = (Profesor)obj;
            if (inscripcionaacomparar.Legajo == this.Legajo)
                return true;
            else
                return false;
        }
    }
}
