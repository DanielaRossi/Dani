using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        //public string ToString()
        //{

        //}
        //internal abstract string Display()
        //{

        //}
    }
}
