using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public abstract class Empleado : Persona 
    {
        private  DateTime _fechaIngreso;
        private  int _legajo;
        private  List<Salario> _salarios;
        
        //private int _antiguedad;
        //private  DateTime _fechaNacimiento;
        //private  Salario _ultimoSalario;

        public  DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public   int Legajo { get => _legajo; set => _legajo = value; }

        //public int Antiguedad { get => _antiguedad; set => _antiguedad = value; }

        //public  DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        //public  Salario UltimoSalario { get => _ultimoSalario; set => _ultimoSalario = value; }

        public Empleado(string apellido, string nombre, DateTime fechanacimiento, int legajo, DateTime fechaingreso):base(apellido, nombre, fechanacimiento)
        {
            //this._ultimoSalario = ultimosalario;
            this._legajo = legajo;
            this._fechaIngreso = fechaingreso;
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
            string mensaje = "";
            mensaje = "Nombre" + this._nombre + "Apellido" + this._apellido;
            return mensaje;
        }
        public string GetNombreCompleto()
        {
            return _apellido +_nombre;
        }
        public virtual string ToString()
        {
            return GetCredencial();
        }
        

}

    }

