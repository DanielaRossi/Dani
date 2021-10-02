using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO.Expendedora.Biblioteca
{
    public class Expendedor
    {
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private List<Lata> _latas;
        public Expendedor(string proveedor, int capacidad, double dinero, bool encendida)
        {
            proveedor = _proveedor;
            capacidad = _capacidad;
            dinero = _dinero;
            encendida = _encendida;
            _latas = new List<Lata>();
        }
        public Expendedor()
        {

        }

        public void AgregarLata(Lata lata)
        {
            
            _latas.Add(lata);
        }
        public void AgregarLata(string codigo,string nombre,string sabor,double precio, double volumen, int cantidad)
        {
            Lata lata = new Lata(codigo, nombre, sabor, precio, volumen, cantidad);
            int TotalLatas = ContarLatas();

            Lata L = BuscarLataporcodigo(codigo);
            if (TotalLatas >= 200)
            {
                throw new LaMaquinaestallena();
            }
            else if(L!=null)
            {
                throw new Elcodigoyaexiste(codigo);
            }
            else
            {
                AgregarLata(lata);
            }
            
        }
        public Lata BuscarLataporcodigo(string codigo)
        {
            return _latas.Find(F => F.Codigo == codigo);
        }
        public int ContarLatas()
        {
            return _latas.Count();
        }
        //    public Lata ExtraerLata(string, double)
        //    {

        //    }
        //    public string GetBalance()
        //    {
        //        return
        //    }
        //    public int GetCapacidadRestante()
        //    {
        //        return
        //    }
        public void EncenderMaquina()
        {
            bool encendido = true;
        }
        public List<Lata> TraerLatas()
        {
            if (_latas.Count == 0)
            {
                return null;
            }
            else
            {
                return _latas;
            }
        }
        //    public bool EstaVacia()
        //    {
        //        return
        //    }

        //}

    }
}
