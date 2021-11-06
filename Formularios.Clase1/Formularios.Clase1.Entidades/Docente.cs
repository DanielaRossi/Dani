using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase1.Entidades
{
    public class Docente : Persona
    {
        private int _legajo;

        public int Legajo { get => _legajo; }



        public Docente(int legajo, string nombre, string apellido, TipoDocumento tipo) : base(nombre, apellido, tipo)
        {
            this._legajo = legajo;
        }
        public string Mostrar
        {
            get
            {
                return $"Docente {this._nombre}";
            }
        }
        

    }
}

