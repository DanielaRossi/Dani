using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar.Exceptiones
{
    class EstudianteInhabilitadoException : Exception
    {
        public EstudianteInhabilitadoException(string message) : base(message)
        {
        }
    }
}
