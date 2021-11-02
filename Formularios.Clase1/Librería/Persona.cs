using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public override string ToString()
        {
            return $"{this._apellido}, {this._nombre} ";
        }
    }
}
