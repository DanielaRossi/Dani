using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.PRACTICAREPUESTOS.BIBLIOTECA.Utilidades;



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
        public void QuitarRepuesto(int codigo)
        {
            //Repuesto repuestoaeliminar = this._listaProductos.Find(x => x.Equals(new Repuesto(codigo)));

            //if (repuestoaeliminar == null)
            //{
            //    throw new Elalumnofueencontrado();
            //}
            //this._listaProductos.Remove(repuestoaeliminar);

            Repuesto repuestoaeliminar = null;

            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Codigo == codigo)
                {
                    if (repuesto.Stock == 0)
                    {
                        repuestoaeliminar = repuesto;
                    }
                    else
                    {
                        throw new ElrepuestonopuedesereliminadoporquetienestockExcepcion();
                    }

                }
            }
            this._listaProductos.Remove(repuestoaeliminar);


        }
        public void ModificarPrecio(int codigo, double precio)
        {
            foreach (Repuesto repuesto in _listaProductos)
            {
                if (repuesto.Codigo == codigo)
                {
                    repuesto.Precio = precio;
                }
            }
        }
        //public void AgregarStock(int, int)
        //{

        //}
        //public void QuitarStock(int, int)
        //{

        //}
        public List<Repuesto> TraerRepuestosPorCategoria(int codigo)
        {
            List<Repuesto> lista = new List<Repuesto>();
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Categoria.Codigo == codigo)
                {
                    lista.Add(r);
                }
            }
            return lista;
        }
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
