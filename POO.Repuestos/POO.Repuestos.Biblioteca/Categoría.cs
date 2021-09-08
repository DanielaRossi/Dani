using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repuestos.Biblioteca
{
    public class Categoría
    {
        private int _código;
        private string _nombre;

        public string Códigocompleto
        {
            get
            {
                return _código.ToString()+ _nombre;
            }
        }
        
        public Categoría(int código, string nombre)
        {
            _código = código;
            _nombre = nombre;
        }
    }
}
