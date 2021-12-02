using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public abstract class Alumno: Persona
    {
        private int _registro;

        protected Alumno(int registro, string nombre, string apellido): base(nombre, apellido)
        {
            Registro = registro;
        }

        public int Registro { get => _registro; set => _registro = value; }
        internal override string Display()
        {
            return $"{this.Nombre}({this._registro})";
        }
    }
}
