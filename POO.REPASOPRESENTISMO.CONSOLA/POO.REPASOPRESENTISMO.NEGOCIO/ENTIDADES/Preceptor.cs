using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public class Preceptor: Persona
    {
        private int _legajo;
        public int Legaje { get => _legajo; set => _legajo = value; }

        public Preceptor(int legajo, string nombre, string apellido): base (nombre, apellido)
        {
            this._legajo = legajo;
        }

        internal override string Display()
        {
            return string.Format("{ 0},{ -(1)}", _apellido, _legajo);
        }
    }
}
