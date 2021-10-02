using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class LaMaquinaestallena: Exception
    {
        public LaMaquinaestallena() : base("La maquina està llena")
        {

        }
    }
}
