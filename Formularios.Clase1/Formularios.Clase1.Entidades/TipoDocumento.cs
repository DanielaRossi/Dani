using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase1.Entidades
{
    public class TipoDocumento
    {
        private int _codigo;
        private string _descripción;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripción { get => _descripción; set => _descripción = value; }

        public TipoDocumento(int codigo, string descripción)
        {
            this._codigo = codigo;
            this._descripción = descripción;
        }
    }
}
