using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repuestos.Biblioteca
{
    public class Repuesto
    {
        private int _código;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoría _categoría;

        public int Código
        {
            get
            {
                return _código;
            }
            set
            {
                _código = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }
        public string CategoriaCompleta
        {
            get
            {
                return _categoría.Códigocompleto;
            }
        }
        public Repuesto(int código, string nombre, double precio, int stock)
        {
            _código = código;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;

            _categoría = new Categoría(_código,_nombre);
        }

    }
}
