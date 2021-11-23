using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    [DataContract]
    public class Tarjeta
    {
        private int _id;
        private int _tipo;
        private int _periodoVencimiento;
        private double _limiteCompra;
        private string _nroPlastico;
        private string _usuario;
        private int _idCliente;
        private Cliente _cliente;

        public Tarjeta( int tipo, int periodoVencimiento, double limiteCompra, string nroPlastico, int idCliente)
        {
            
            _tipo = tipo;
            _periodoVencimiento = periodoVencimiento;
            _limiteCompra = limiteCompra;
            _nroPlastico = nroPlastico;
            
            _idCliente = idCliente;
            
        }

        public int Id { get => _id; set => _id = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public int PeriodoVencimiento { get => _periodoVencimiento; set => _periodoVencimiento = value; }
        public double LimiteCompra { get => _limiteCompra; set => _limiteCompra = value; }
        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }

        public override string ToString()
        {

            //return $"{this.IdCliente}) {(TipoTarjetaEnum)this.Tipo} {this.NroPlastico} - {this.LimiteCompra.ToString("$ 0.00") }";
            return string.Format("{0})-{1}{2}-Limite:{4}", this.IdCliente, this.Tipo, this.NroPlastico, this.LimiteCompra.ToString("0.00)"));
        }
    }
}
