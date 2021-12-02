using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Venta
    {
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        public Venta( Cliente cliente, int estado, int codigo)
        {
            _items = new List<VentaItem>();
            _cliente = cliente;
            _estado = estado;
            _codigo = codigo;
        }

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }

        //public double GetTotalPedido()
        //{
        //    return 
        //}
    }
}
