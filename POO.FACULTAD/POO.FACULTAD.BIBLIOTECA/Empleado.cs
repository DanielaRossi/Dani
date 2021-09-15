using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Empleado
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public DateTime FechaIngreso { get => _fechaIngreso; }
        public int Legajo { get => _legajo; }

        public Empleado(DateTime fechaingreso, int legajo)
        {
            this._fechaIngreso = fechaingreso;
            this._legajo = legajo;
            _salarios = new List<Salario>();
        }

    }
}
