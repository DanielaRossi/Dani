using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repuestos.Biblioteca
{
    public class VentaRepuestos
    {
        private string _nombreComercio;
        private string _dirección;
        private List<Repuesto> _repuestos;

        public string NombreComercio
        {
            get
            {
                return _nombreComercio;
            }
        }
        public string Dirección
        {
            get
            {
                return _dirección;
            }
        }
        public VentaRepuestos(string nombre, string dirección)
        {
            _nombreComercio = nombre;
            _dirección = dirección;
            _repuestos = new List<Repuesto>();
        }
        public List<Repuesto> Traerrepuestos()
        {
            if (_repuestos.Count == 0)
                return null;
            else
                return _repuestos;
        }
        public bool AgregarRepuesto(Repuesto re)
        {
            // validar que re no sea null
            
           // No lo entiendo

            //int nuevoCodigo = TraerNuevoCodigo();

            //Repuesto repuesto = new Repuesto(re, nuevoCódigo);

            _repuestos.Add(re);

            return true;
        }
        //private int TraerNuevoCodigo()
        //{
         //   return 0;
       // }
    }
}
