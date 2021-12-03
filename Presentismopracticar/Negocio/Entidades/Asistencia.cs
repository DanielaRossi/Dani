using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public Asistencia(string fechaReferencia, Preceptor preceptor, Alumno alumno, bool estaPresente)
        {
            _fechaReferencia = fechaReferencia;
            _fechaHoraReal = DateTime.Today;
            _preceptor = preceptor;
            _alumno = alumno;
            _estaPresente = estaPresente;
        }

        public string FechaReferencia { get => _fechaReferencia; set => _fechaReferencia = value; }
        public DateTime FechaHoraReal { get => _fechaHoraReal; set => _fechaHoraReal = value; }
        public Preceptor Preceptor { get => _preceptor; set => _preceptor = value; }
        public Alumno Alumno { get => _alumno; set => _alumno = value; }
        public bool EstaPresente { get => _estaPresente; set => _estaPresente = value; }

        public override string ToString()
        {
            return $"{this.FechaReferencia}-{this._alumno.Display()} está presente {this._estaPresente} por {this._preceptor.Display()} registrado el {this._fechaHoraReal}";
        }
    }
}
