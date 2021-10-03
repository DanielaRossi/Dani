using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.almacen.biblioteca
{
    class Idproducto
    {
        private string _letras;
        private int _codigo;

        public string IdCompleto
        {
            get
            {
                return _letras + _codigo.ToString();
            }
        }
    }
}
