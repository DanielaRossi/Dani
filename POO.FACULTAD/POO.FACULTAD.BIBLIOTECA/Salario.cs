using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Salario
    {
        private  double _bruto;
        private  string _codigoTransferencia;
        private  double _descuentos;
        private  DateTime _fecha;

        public  double Bruto { get => _bruto; set => _bruto = value; }
        
        public  string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia= value; }

        public  double Descuento{ get => _descuentos; set => _descuentos = value; }

        public  DateTime Fecha { get => _fecha; set => _fecha = value; }

        //public static overide double GetSalarioNeto()
        //{

        //}
        //public static double Salario(double)
        //{

        //}
    }
}
