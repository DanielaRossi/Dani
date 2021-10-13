using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class Elcodigoyaexiste : Exception
    {
        public Elcodigoyaexiste(string codigo) : base("El codigo ya existe")
        {

        }
    }
}
