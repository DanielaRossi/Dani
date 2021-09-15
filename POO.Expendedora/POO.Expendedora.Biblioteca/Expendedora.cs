using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class Expendedora
    {
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private List<Lata> _latas;

        public string Proveedor
        {
            get
            {
                return _proveedor;
            }
        }
        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
        }
        public double Dinero
        {
            get
            {
                return _dinero;
            }
        }
        public bool Encendida
        {
            get
            {
                return _encendida;
            }
        }
        public Expendedora(string proveedor,int capacidad, double dinero, bool encendida)
        {
            proveedor = _proveedor;
            capacidad = _capacidad;
            dinero = _dinero;
            encendida = _encendida;
            _latas = new List <Lata>();
        }
        public void AgregarLata(Lata)
        {

        }
        public Lata ExtraerLata(string, double)
        {

        }
        public string GetBalance()
        {
            return
        }
        public int GetCapacidadRestante()
        {
            return
        }
        public void EncenderMaquina()
        {

        }
        public bool EstaVacia()
        {
            return
        }
       
    }
}
