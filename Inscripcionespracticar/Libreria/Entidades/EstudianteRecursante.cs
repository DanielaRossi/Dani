using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class EstudianteRecursante: Estudiante
    {
        private int _cantidadCursosTomados;

        public EstudianteRecursante( int registro, string nombre, string apellido, string email,int cantidadCursosTomados) : base(registro,nombre, apellido, email)
        {
            _cantidadCursosTomados = cantidadCursosTomados;
        }

        public int CantidadCursosTomados { get => _cantidadCursosTomados; set => _cantidadCursosTomados = value; }
    }
}
