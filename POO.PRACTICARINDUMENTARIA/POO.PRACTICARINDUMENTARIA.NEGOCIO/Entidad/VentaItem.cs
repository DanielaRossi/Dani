using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public Indumentaria Prenda { get => _prenda; set => _prenda = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        //public double GetTotal()
        //{
        //    return
        //}
    }
}
