using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        protected Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public override string ToString()
        {
            return Display();
        }
        internal abstract string Display();
        
    }
} 
