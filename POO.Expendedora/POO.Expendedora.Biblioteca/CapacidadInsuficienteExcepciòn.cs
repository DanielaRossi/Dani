using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class CapacidadInsuficienteExcepciòn : Exception
    {
        public CapacidadInsuficienteExcepciòn(): base("La capacidad es insuficiente")
        {

        }
    }
}
