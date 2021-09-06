using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.almacen.biblioteca
{
    public class Producto
    {
        //atributos de clase
        private string _nombreProducto;
        private Idproducto _Id;
        private int _stockProducto;
        private float _precioProducto;
        private string _marcaProducto;
        

        //propiedades
        public string Id
        {
            get
            {
                return _Id.IdCompleto;
            }
        }
        public string _NombreProducto
        {
            get
            {
                return _nombreProducto;
            }
            set
            {
                _nombreProducto = value;
            }
        }
        public float _PrecioProducto
        {
            get
            {
                return _precioProducto;
            }
            set
            {
                _precioProducto = value;
            }
        }
        public int _StockProducto
        {
            get
            {
                return _stockProducto;
            }
            set
            {
                _stockProducto = value;
            }
        }

        //Es un metodo que modifica a un atributo( comportamiento modifica estado)
        public void Venta()
        {
            _StockProducto--;
        }
        // es un metodo que se ve modificado su comportamiento por el valor de un atributo
        public void ReponerStock()
        {
            if(_StockProducto<10)
            {
                Console.Write("Debe reponer el stock");
            }
            else
            {
                Console.Write("El stock es suficiente.");
            }
        }
        public Producto()
        {
            _Id = new Idproducto();

        }
   
    }
}
