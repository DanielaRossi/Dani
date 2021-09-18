using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Alumno : Persona
    {
        protected int _codigo;
        protected string _credencial;

        public string Credencial { get => _credencial; set => _credencial = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }

        //public string GetCredencial()
        //{

        //}
        //public string ToString()
        //{

        //}
    }
}
