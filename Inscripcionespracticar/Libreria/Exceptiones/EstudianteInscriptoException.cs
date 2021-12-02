using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar.Exceptiones
{
    public class EstudianteInscriptoException: Exception
    {
        public EstudianteInscriptoException():base("El estudiante ya esta inscripto en la materia.") { }
        
    }
}
