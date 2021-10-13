using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return "Nombre completo del directivo.";
        }
    }
}
