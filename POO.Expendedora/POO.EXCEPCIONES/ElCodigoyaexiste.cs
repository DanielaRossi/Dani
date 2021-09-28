using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.EXCEPCIONES
{
    public class ElCodigoyaexiste : Exception
    {
        public ElCodigoyaexiste() : base: ("El codigo ya existe")
        {
        }
    }
}
