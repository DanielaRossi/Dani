using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public VentaItem(Indumentaria prenda, int cantidad)
        {
            Prenda = prenda;
            Cantidad = cantidad;
        }

        public Indumentaria Prenda { get => _prenda; set => _prenda = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        //public double GetTotal()
        //{
        //    return 
        //}
    }
}
