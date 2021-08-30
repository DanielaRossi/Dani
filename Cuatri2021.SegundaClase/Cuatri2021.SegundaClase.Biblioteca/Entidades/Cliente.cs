using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.SegundaClase.Biblioteca
{
    public class Cliente
    {
        //atributos de clase
        private int _numeroDocumento;
        private string _nombre;
        private string _apellido;
        private DateTime _edad;

        public int NumeroDocumento
        {
            get
            {
                return _numeroDocumento;
            }
            set
            {
                _numeroDocumento = value;
            }
        }
    }
}
