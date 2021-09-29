using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;
        public string _FechaReferencia;

        public string FechaReferencia { get => _fechaReferencia; set => _fechaReferencia = value; }
        public DateTime FechaHoraReal { get => _fechaHoraReal; set => _fechaHoraReal = value; }
        public Preceptor Preceptor{ get => _preceptor; set => _preceptor = value; }
        public Alumno Alumno { get => _alumno; set => _alumno = value; }
        public bool EstaPresente { get => _estaPresente; set => _estaPresente = value; }

        public string GetAsistencia()
        {
            return string.Format("", );
        }

    }
}
