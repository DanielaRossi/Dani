using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.EXCEPCIONES
{
    public class AsistenciaExistenteEseDiaExcepcion: Exception
    {
        public AsistenciaExistenteEseDiaExcepcion(): base("La fecha ingresada ya existe.")
        {

        }
    }
}
