using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.TerceraClase.Biblioteca
{
    public class Dirección
    {
        //atributos
        private string _calle;
        private int _altura;
        //propiedades
        public string DireccionCompleta
        {
            get
            {
                return _calle + "Puerta" + _altura.ToString();
            }
        }
        public Dirección(string calle, int altura)
        {
            this._calle = calle;
            this._altura = altura;
        }

    }
}
