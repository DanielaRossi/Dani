using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class Materia
    {
        private int _codigo;
        private string _descripcion;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public Materia(int codigo, string descripcion)
        {
            _codigo = codigo;
            _descripcion = descripcion;
        }
        public Materia()
        {

        }








        //public string Descripcion { get => _descripcion; set => _descripcion = value; }
        //public int Codigo { get => _codigo; set => _codigo = value; }

        //public Materia(int codigo, string descripcion)
        //{
        //    Codigo = codigo;
        //    Descripcion = descripcion;
        //}



        public override string ToString()
        {
            return $"{this.Codigo})¨{this.Descripcion}";
        }
        public override bool Equals(object obj)
        {
            // como recibe un obj hay que preguntar si el tipo es correcto
            if (!(obj is Materia))
                return false;

            // sabiendo que el tipo es correcto, casteamos y guardamos el objeto casteado
            Materia objetoACompararCasteado = (Materia)obj;

            // comparamos el objeto a comparar con el obj propio
            if (objetoACompararCasteado.Codigo == this.Codigo)
                return true;
            else
                return false;
        }

    }
}
