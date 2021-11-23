using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    [DataContract]
    public class Cliente: Persona
    {
        private int _id;

        private string _apellido;
        private string _direccion;
        private long _DNI;
        private string _email;

        private Tarjeta _tarjeta;
        private DateTime _fechaNac;
        private string _telefono;
        private bool _activo;

        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "DNI")]
        public long DNI { get => _DNI; set => _DNI = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "Direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }

        public Tarjeta Tarjeta { get => _tarjeta; set => _tarjeta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        [DataMember(Name = "FechaNacimiento")]
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public Cuenta Cuenta { get; set; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return string.Format("{0},{1}", this._apellido, this._nombre);
        }
        public string DisplayParaCombo
        {
            get
            {
                return $"{this._apellido}, {this._nombre}";
            }
        }
    }
}
