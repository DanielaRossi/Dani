using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;
        private string _email;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }

        public Persona(string nombre, string apellido, string email)
        {
            Nombre = this.Nombre;
            Apellido = apellido;
            Email = email;
        }

        public  Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            
        }

       

        public override string ToString()
        {
            return Mostrar();
        }
        internal abstract string Mostrar();
    }
}
