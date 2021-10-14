using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public class Venta
    {
        private Cliente _cliente;
        public List<VentaItem> Items;
        
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public int Estado;
        public int Codigo;

        //public double GetTotalPedido()
        //{
        //    return
        //}
    }
}
