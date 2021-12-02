using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Excepciones
{
    public class AsistenciaExistenteEseDiaException : Exception
    {
        public AsistenciaExistenteEseDiaException() : base("No hay asistencias ese día.") { }
        
    }
}
