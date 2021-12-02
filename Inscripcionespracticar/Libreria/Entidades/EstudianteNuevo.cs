using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class EstudianteNuevo : Estudiante
    {
        public EstudianteNuevo(int registro, string nombre, string apellido, string email) : base(registro, nombre, apellido, email)
        {
        }
    }
}
