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

        //public string ToString()
        //{

        //}
    }
}
