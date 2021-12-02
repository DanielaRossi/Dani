using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public abstract class Estudiante: Persona
    {
        private int _registro;

        public int Registro { get => _registro; set => _registro = value; }

        protected Estudiante(int registro,string nombre, string apellido, string email): base(nombre, apellido,email)
        {
            Registro = registro;
        }

        

        internal override string Mostrar()
        {
            return $"{this.Nombre}({this.Email}";
        }
        public override bool Equals(object obj)
        {
            // como recibe un obj hay que preguntar si el tipo es correcto
            if (!(obj is Estudiante))
                return false;

            // sabiendo que el tipo es correcto, casteamos y guardamos el objeto casteado
            Estudiante objetoACompararCasteado = (Estudiante)obj;

            // comparamos el objeto a comparar con el obj propio
            if (objetoACompararCasteado.Registro == this.Registro)
                return true;
            else
                return false;
        }
    }
}
