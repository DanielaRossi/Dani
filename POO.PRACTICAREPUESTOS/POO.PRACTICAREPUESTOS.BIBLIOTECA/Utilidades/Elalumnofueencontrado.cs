using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICAREPUESTOS.BIBLIOTECA.Utilidades
{
    public class Elalumnofueencontrado: Exception
    {
        public Elalumnofueencontrado(): base(" El alumno no fue encontrado")
        {

        }
    }
}
