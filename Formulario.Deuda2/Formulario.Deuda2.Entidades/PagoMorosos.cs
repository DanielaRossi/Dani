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
        private double _interesesPunitorios;
        private double _importeTotal;
        private string _usuario;
        private Servicio _servicio;

        public int Id { get => _id; set => _id = value; }
        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public double ImporteAdeudado { get => _importeAdeudado; set => _importeAdeudado = value; }
        public double InteresesPunitorios { get => _interesesPunitorios; set => _interesesPunitorios = value; }
        public double ImporteTotal { get => _importeTotal; set => _importeTotal = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public Servicio Servicio { get => _servicio; set => _servicio = value; }
    }
}
