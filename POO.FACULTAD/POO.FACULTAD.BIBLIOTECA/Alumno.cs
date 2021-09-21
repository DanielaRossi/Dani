using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Alumno : Persona
    {
        protected int _codigo;
        protected string _credencial;

        public string Credencial { get => _credencial; set => _credencial = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }

        public Alumno(int codigo, string apellido, string nombre): base(apellido, nombre)
        {
            this._codigo = codigo;
            
        }
        public Alumno(int codigo, string apellido, string nombre, DateTime fechanacimiento): base(apellido, nombre,fechanacimiento)
        {
            this._codigo = codigo;
            
        }

        public string GetCredencial()
        {
            return string.Format("Codigo {0},{1},{3}", this._codigo, this._apellido, this._nombre);
        }
        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
