using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public class TiendaRopa
    {
        private List<Indumentaria> _Inventario;
        private List<Venta> _Ventas;
        private int _ultimoCodigo;

        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }

        //private int GetProximoCodigo()
        //{
        //    return
        //}
        //public void Agregar(Indumentaria a)
        //{

        //    Camisa camisaNegra = new Camisa();
        //    Pantalon pantalonNegro = new Pantalon();
        //    indumentarias.Add(camisaNegra);
        //    indumentarias.Add(pantalonNegro);
        //}
        public void AgregarCamisa(int codigo, int stock, string talle, double precio, TipoIndumentaria t,bool estampado, string manga)
        {
            Camisa camisaNegra = new Camisa(codigo, stock, talle, precio, t, estampado, manga);
            AgregarCamisa(camisaNegra);

        }
        public void AgregarCamisa(Camisa a)
        {
            _Inventario.Add(a);

        }
        //public void Modificar(Indumentaria)
        //{

        //}
        //public void Quitar(Indumentaria)
        //{

        //}
        //public void IngresarOrden(Venta)
        //{

        //}
        public List<Indumentaria> Listar()
        {
            if(_Inventario.Count == 0)
            {
                return null;
            }
            else
            {
                return _Inventario;
            }
        }
        //public List<Orden> ListarOrden()
        //{

        //}
        //public void DevolverOrden(Orden)
        //{

        //}


    }
}
