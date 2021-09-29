using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public abstract class Alumno: Persona
    {
        private int _registro;
        public int Registro { get => _registro; set => _registro = value; }

        public override string ToString()
        {
            return string.Format("{0}({1})", GetNombre(), _registro);
        }
    }
}