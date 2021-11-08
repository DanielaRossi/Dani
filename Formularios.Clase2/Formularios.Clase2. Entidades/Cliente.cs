using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Clase2.Entidades
{
    public class Cliente: Persona
    {
        private int _id;
        private bool _activo;
        public int Id { get => _id; set => _id = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public Cliente (int id, bool activo, string nombre, string apellido, string direcciòn, string telefono, string email, DateTime fechanacimiento, long cuit) : base(nombre, apellido, direcciòn, telefono, email, fechanacimiento, cuit)
        {
            this._id = id;
            this._activo = activo;
        }

        public string Mostrar()
        {
            return $"{this._id},{this._apellido}, {this._nombre}, {this._cuit}";
        }



    }
}
