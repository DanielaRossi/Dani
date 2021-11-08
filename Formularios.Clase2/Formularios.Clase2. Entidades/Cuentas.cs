using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase2.Entidades
{
    public class Cuentas
    {
        private int _id;
        private int _nroCuenta;
        private string _descripcion;
        private double _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;

        public int Id { get => _id; set => _id = value; }
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }

        public bool Activo { get => _activo; set => _activo = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

        public Cuentas(int id, int nrocuenta, string descripcion,double saldo, DateTime fechaapertura, DateTime fechamodificacion, bool activo, int idcliente)
        {
            this._id = id;
            this._nroCuenta = nrocuenta;
            this._descripcion = descripcion;
            this._saldo = saldo;
            this._fechaApertura = fechaapertura;
            this._fechaModificacion = fechamodificacion;
            this._activo = activo;
            this._idCliente = idcliente;

        }
        public string Mostrar()
        {
            return  this._id + this._nroCuenta+this._descripcion+ this._idCliente;
            return $"Id {this._id}, Nro Cuenta {this._nroCuenta}, Descripcion {this._descripcion}, IdCliente{this._idCliente}";
        }

    }
}
