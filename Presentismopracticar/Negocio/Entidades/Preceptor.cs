using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Preceptor: Persona
    {
        private int _legajo;

        public Preceptor(int legajo, string nombre, string apellido): base(nombre, apellido)
        {
            Legajo = legajo;
        }

        public int Legajo { get => _legajo; set => _legajo = value; }

        internal override string Display()
        {
            return $"{this.Apellido}-{this._legajo}";
        }
    }
}
