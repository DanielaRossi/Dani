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

        //public void AgregarLata(Lata)
        //{

        //}
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
        //    public bool EstaVacia()
        //    {
        //        return
        //    }

        //}

    }
}
