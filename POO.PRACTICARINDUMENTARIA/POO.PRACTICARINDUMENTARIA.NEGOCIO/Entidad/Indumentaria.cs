using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria _tipo;
        private int _codigo;
        private int _stock;
        private string _talle;
        private double _precio;

        public TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public Indumentaria(int codigo, int stock, string talle, double precio, TipoIndumentaria tipo)
        {
            this._codigo = codigo;
            this._stock = stock;
            this._talle = talle;
            this._precio = precio;
            this._tipo = tipo;

        }

        public string ToString()
        {
            return GetDetalle();
        }
        //public override bool Equals(object obj)
        //{
        //    if(obj == null)
        //    {
        //        return false;
        //    }
        //    if(this._codigo ==())
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public string GetDetalle()
        {
            return string.Format("{0}-{1}-{2}-{3}-{4}", _tipo, _codigo, _stock, _talle, _precio);
        }

    }
}
