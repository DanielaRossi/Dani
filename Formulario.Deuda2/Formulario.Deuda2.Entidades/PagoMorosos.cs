using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Entidades
{
    public class PagoMorosos
    {
        private int _id;
        private int _idServicio;
        private int _idCliente;
        private DateTime _fechaVencimiento;
        private DateTime _fechaPago;
        private double _importeAdeudado;
        //private double _interesespunitorios;
        //private double _importetotal;
        
        private string _usuario;
        private Servicio _servicio;

        public PagoMorosos(int idServicio, DateTime fechaVencimiento, DateTime fechaPago, double importeAdeudado)
        {
            
            _idServicio = idServicio;
            
            _fechaVencimiento = fechaVencimiento;
            _fechaPago = fechaPago;
            _importeAdeudado = importeAdeudado;
            
            
        }

        public int Id { get => _id; set => _id = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public double ImporteAdeudado { get => _importeAdeudado; set => _importeAdeudado = value; }
        //public double InteresesPunitorios { get => _interesesPunitorios; set => _interesesPunitorios = value; }
        //public double ImporteTotal { get => _importeTotal; set => _importeTotal = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public Servicio Servicio { get => _servicio; set => _servicio = value; }
        //public double Servicio
        //{
        //    get
        //    {
        //        return _servicio.PunitoiroDiario;
        //    }
        //}
        public double InteresesPunitorios
        {
            get
            {
                return (FechaPago - FechaVencimiento).Days * Servicio.PunitoiroDiario ;
            }
        }
        
        public double ImporteTotal
        {
            get
            {
                return ImporteAdeudado + InteresesPunitorios;
            }
        }
        public double AtrasoDias
        {
            get
            {
                return (FechaPago - FechaVencimiento).Days;
            }
        }
        

        public override string ToString()
        {
            //return string.Format("{0}){1}-{2}-{3}", this.Id,this.Servicio.Nombre,this.ImporteTotal,this.AtrasoDias);
            return $"{this.Id},{this.Servicio.Nombre},{this.ImporteTotal.ToString("0.00")},{this.AtrasoDias}";
            

        }


        //public List<Servicio> CargarServicio { get }
    }
}
