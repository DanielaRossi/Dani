using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class Inscripcion
    {
        private DateTime _fechaInscripcion;
        private Profesor _profesor;
        private Estudiante _estudiante;
        private Materia _materia;

        public Inscripcion( Profesor profesor, Estudiante estudiante, Materia materia)
        {
            FechaInscripcion = DateTime.Today;
            Profesor = profesor;
            Estudiante = estudiante;
            Materia = materia;
        }

        public DateTime FechaInscripcion { get => _fechaInscripcion; set => _fechaInscripcion = value; }
        public Profesor Profesor { get => _profesor; set => _profesor = value; }
        public Estudiante Estudiante { get => _estudiante; set => _estudiante = value; }
        public Materia Materia { get => _materia; set => _materia = value; }

        public override string ToString()
        {
            return $"{this.FechaInscripcion}-{this.Estudiante.Mostrar()} inscripto a {this.Materia.ToString()}";
        }
        
    }
}
