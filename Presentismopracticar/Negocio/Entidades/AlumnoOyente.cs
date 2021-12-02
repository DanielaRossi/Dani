using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class AlumnoOyente : Alumno
    {
        public AlumnoOyente(int registro, string nombre, string apellido) : base(registro, nombre, apellido)
        {
        }
    }
}
