using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class DineroInsuficienteExcepciòn : Exception
    {
        public DineroInsuficienteExcepciòn(): base(" El dinero es insuficiente")
        {

        }
    }
}
