using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public abstract class Estudiante: Persona
    {
        private int _registro;

        protected Estudiante(int registro,string nombre, string apellido, string email): base(nombre, apellido,email)
        {
            _registro = registro;
        }

        public int Registro { get => _registro; set => _registro = value; }

        internal override string Mostrar()
        {
            return $"{this.Nombre}({this.Email}";
        }
    }
}
