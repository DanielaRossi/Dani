using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Empleado : Persona
    {
        private  DateTime _fechaIngreso;
        private  int _legajo;
        private  List<Salario> _salarios;
        private int _antiguedad;
        private  DateTime _fechaNacimiento;
        private  Salario _ultimoSalario;

        public  DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public   int Legajo { get => _legajo; set => _legajo = value; }

        public int Antiguedad { get => _antiguedad; set => _antiguedad = value; }

        public  DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public  Salario UltimoSalario { get => _ultimoSalario; set => _ultimoSalario = value; }

        public Empleado(int legajo, Salario ultimosalario, string apellido, string nombre):base(apellido, nombre)
        {
            this._ultimoSalario = UltimoSalario;
            this._legajo = legajo;
            _salarios = new List<Salario>();
        }

        //public void AgregarSalario(Salario)
        //{

        //}
        //public bool Equals(object)
        //{
        //    return
        //}
        public string GetCredencial()
        {
            return string.Format("{0} - {1} salario $ {3}", this._legajo, GetNombreCompleto(), this._ultimoSalario);
        }
        public string GetNombreCompleto()
        {
            return _apellido +_nombre;
        }
        public override string ToString()
        {
            return GetCredencial();
        }

    }
}
