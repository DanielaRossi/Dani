using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public class  Preceptor: Persona
    {
        private int _legajo;
        public int Legajo { get => _legajo; set => _legajo = value; }

        public override string ToString()
        {
            return string.Format("{0}-{1}",GetApellido(), _legajo);
        }
    }
}
