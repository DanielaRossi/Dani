using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase2.Entidades
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _dirección;
        protected string _telefono;
        protected string _email;
        protected DateTime _fechaNacimiento;
        protected long _cuit;
        




        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Dirección { get => _dirección; set => _dirección = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public long Cuit { get => _cuit; set => _cuit = value; }
        

        public Persona(string nombre, string apellido, string direcciòn, string telefono, string email, DateTime fechanacimiento, long cuit)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dirección = direcciòn;
            this._telefono = telefono;
            this._email = email;
            this._fechaNacimiento = fechanacimiento;
            this._cuit = cuit;
            
        }

        

        public override string ToString()
        {
            return $"{this._apellido}, {this._nombre}, {this._dirección}, {this._telefono}, {this._email}, {this._fechaNacimiento}, {this._cuit}";
        }
    }
}
