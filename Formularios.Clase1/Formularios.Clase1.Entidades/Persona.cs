using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase1.Entidades
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected TipoDocumento _tipoDocumento;


        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public TipoDocumento TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }

        public Persona(string nombre, string apellido, TipoDocumento tipo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._tipoDocumento = tipo;
        }
        public override string ToString()
        {
            return $"{this._apellido}, {this._nombre}, {this._tipoDocumento} ";
        }
    }
}
