using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar.Exceptiones
{
    class EstudianteInhabilitadoException : Exception
    {
        public EstudianteInhabilitadoException():base("El estudiante está inhabilitado por superar la cantidad de cursos tomados.") { }
        
    }
}
