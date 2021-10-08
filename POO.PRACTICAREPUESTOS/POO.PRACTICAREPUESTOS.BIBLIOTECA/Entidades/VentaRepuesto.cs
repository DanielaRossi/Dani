using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICAREPUESTOS.BIBLIOTECA.Entidades
{
    public class VentaRepuesto
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _dirección;

        public string NombreComercio { get => _nombreComercio;  }
        public string Direccion{ get => _dirección; }

        public VentaRepuesto(string nombre, string direccion)
        {
            this._nombreComercio = nombre;
            this._dirección = direccion;
            _listaProductos = new List<Repuesto>();
        }
        public void AgregarRepuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            Repuesto re = new Repuesto(codigo, nombre, precio, stock, categoria);
            AgregarRepuesto(re);
        }
        

        public void AgregarRepuesto(Repuesto re)
        {
           
            _listaProductos.Add(re);
        }
        //public void QuitarRepuesto(int)
        //{

        //}
        //public void ModificarPrecio(int, double)
        //{

        //}
        //public void AgregarStock(int, int)
        //{

        //}
        //public void QuitarStock(int, int)
        //{

        //}
        //public List<Repuesto> TraerPorCategoria(int)
        //{

        //}
        public List<Repuesto> TraerRepuestos()
        {
            if (_listaProductos.Count == 0 )
            {
                return null;
            }

            else
            {
                return _listaProductos;
            }
        }
    }
}
