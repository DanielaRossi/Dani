using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public abstract class Alumno: Persona
    {
        private int _registro;
        public int Registro { get => _registro; set => _registro = value; }

        public Alumno(int registro, string nombre, string apellido): base(nombre, apellido)
        {
            this._registro = registro;
        }

        internal string Display()
        {
            return string.Format("{ 0},{ (1)}", _nombre, _registro);
        }
    }
}
