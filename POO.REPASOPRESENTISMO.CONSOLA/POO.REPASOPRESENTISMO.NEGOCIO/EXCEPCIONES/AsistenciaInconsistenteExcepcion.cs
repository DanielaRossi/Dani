using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.EXCEPCIONES
{
    public class AsistenciaInconsistenteExcepcion: Exception
    {
        public AsistenciaInconsistenteExcepcion():base("La existencia es inconsistente")
        {

        }
    }
}
