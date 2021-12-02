using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria _tipo;
        private int _codigo;
        private int _stock;
        private string _talle;
        private double _precio;

        protected Indumentaria(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio)
        {
            Tipo = tipo;
            Codigo = codigo;
            Stock = stock;
            Talle = talle;
            Precio = precio;
        }

        public TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return GetDetalle();
        }
        public override bool Equals(object obj)
        {
            
            if (!(obj is Indumentaria))
                return false;

            
            Indumentaria objetoACompararCasteado = (Indumentaria)obj;

            // comparamos el objeto a comparar con el obj propio
            if (objetoACompararCasteado.Codigo == this.Codigo)
                return true;
            else
                return false;
        }
        public abstract string GetDetalle(); 
    }
}
