using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;
        public string FechaReferencia { get => _fechaReferencia; set => _fechaReferencia = value; }

        public Asistencia(string fecha, DateTime fechareal, Preceptor preceptor,Alumno alumno, bool presente)
        {
            _fechaReferencia = fecha;
            this._fechaHoraReal = fechareal;
            this._preceptor = preceptor;
            this._alumno = alumno;
            this._estaPresente = presente;

        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-Esta presente{2}por{3} registrado el {4}", _fechaReferencia, _alumno, _estaPresente, _preceptor, _fechaHoraReal);
        }
    }
}
