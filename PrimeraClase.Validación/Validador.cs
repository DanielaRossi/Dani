using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase.Validación
{
    public class Validador
    {
        public static bool EsValido(int numero)
        {
            if(numero==2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
