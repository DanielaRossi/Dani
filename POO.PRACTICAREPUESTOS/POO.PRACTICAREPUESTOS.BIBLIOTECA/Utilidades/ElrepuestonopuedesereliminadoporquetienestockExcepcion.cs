using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICAREPUESTOS.BIBLIOTECA.Utilidades
{
    public class ElrepuestonopuedesereliminadoporquetienestockExcepcion : Exception
    {
        public ElrepuestonopuedesereliminadoporquetienestockExcepcion(): base("El repuesto no se puede eliminar porque tiene stock")
        {

        }
    }
}
