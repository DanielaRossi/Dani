using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Entidades.Excepciones
{
    class ClienteSinCuentaExpection : Exception
    {
        public ClienteSinCuentaExpection() :base("El cliente no tiene cuenta"){ }
        
        
    }
}
