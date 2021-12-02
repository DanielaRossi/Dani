using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _ultimoCodigo;
        private List<Cliente> _clientes;
        private List<TipoIndumentaria> _tipoindumentaria;

        public TiendaRopa(int ultimoCodigo)
        {
            _ultimoCodigo = ultimoCodigo;
            _ventas = new List<Venta>();
            _inventario = new List<Indumentaria>();
            _clientes = new List<Cliente>();
            _tipoindumentaria = new List<TipoIndumentaria>();

            _clientes.Add (new Cliente(5, "Jorgelina", "Ramos"));
            _clientes.Add (new Cliente (6, "Juan", "Gutierrez"));

            _tipoindumentaria.Add(new TipoIndumentaria("Argentino", 0.90));
            _tipoindumentaria.Add(new TipoIndumentaria("Chino", 0.80));
            
        }

        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }

        public int GetProximoCodigo()
        {

        }
        public void Agregar(Indumentaria indumentaria)
        {

        }
        public void Modificar(Indumentaria indumentaria)
        {

        }
        public void Quitar(Indumentaria indumentaria)
        {

        }
        public void IngresarOrden(Venta venta)
        {

        }
        public List<Orden> LisarOrden()
        {

        }
        public void DevolverOrden(Orden)
        {

        }
    }
}
