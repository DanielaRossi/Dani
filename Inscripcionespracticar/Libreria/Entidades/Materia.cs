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

        public Materia(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public override string ToString()
        {
            return $"{this._codigo})¨{this._descripcion}";
        }
    }
}
