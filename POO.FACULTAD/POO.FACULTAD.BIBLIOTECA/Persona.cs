using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Persona
    {
        protected string _apellido;
        protected  DateTime _fechaNac;
        protected string _nombre;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad
        {
            get
            {
                return Convert.ToInt32(Salario.Fecha - _fechaNac );
            }
            
        }
        public Persona(string apellido, string nombre)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        public Persona(string apellido, string nombre, DateTime fechanacimiento)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._fechaNac = fechanacimiento;
        }

        //public override string GetCredencial()
        //{

        //}
        //    public override string GetNombreCompleto()
        //    {

        //    }
        //}
    }
