using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public abstract class Persona 
    {
        protected string _nombre;
        protected string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => value = _apellido; }

        
        public string GetNombre()
        {
            return string.Format("{0}", _nombre);
        }
        public string GetApellido()
        {
            return string.Format("{0}", _apellido);
        }
        
    }
}
