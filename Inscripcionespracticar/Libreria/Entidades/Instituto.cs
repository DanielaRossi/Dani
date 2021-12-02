using Inscripcionespracticar.Exceptiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{
    public class Instituto
    {
        private string _nombre;
        private List<Profesor> _profesores;
        private List<Estudiante> _estudiantes;
        private List<Inscripcion> _inscripciones;
        private List<Materia> _materias;

        // iniciar Instituto con los siguientes datos
        public Instituto(string nombre)
        {
            _nombre = nombre;
            _estudiantes = new List<Estudiante>();
            _inscripciones = new List<Inscripcion>();
            _profesores = new List<Profesor>();
            _materias = new List<Materia>();


            _estudiantes.Add(new EstudianteRecursante(123, "Carlos", "Juarez", "cjua@gmail.com", 2));
            _estudiantes.Add(new EstudianteRecursante(124, "Carla", "Jaime", "cjai@gmail.com", 3));
            _estudiantes.Add(new EstudianteNuevo(320, "Ramona", "Vals", "vals@gmail.com"));
            _estudiantes.Add(new EstudianteNuevo(321, "Alejandro", "Medina", "medi@gmail.com"));

            _profesores.Add(new Profesor(5, "Jorgelina", "Ramos"));
            _profesores.Add(new Profesor(6, "Juan", "Gutierrez"));

            _materias.Add(new Materia(1, "Matemática Discreta I"));
            _materias.Add(new Materia(2, "Algoritmos I"));
            _materias.Add(new Materia(3, "Electromagnetismo I"));


        }

        

        

        public string Nombre { get => _nombre; set => _nombre = value; }

        public Profesor GetProfesor( int legajo)
        {
            Profesor profesor = null;
            foreach(Profesor p in _profesores)
            {
                if (p.Legajo == legajo)
                {
                    profesor= p;
                }
               

            }
            return profesor;
        }
        public List<Materia> GetMaterias()
        {
            return _materias;
        }
        public Materia GetMateriasporcodigo(int codigo)
        {
            Materia materia = null;
            foreach(Materia m in _materias)
            {
                if(m.Codigo == codigo)
                {
                    materia = m;
                }
            }
            
            if (materia == null)
            {
                throw new Exception("No existe la materia.");
            }
            return materia;
        }
        public List<Estudiante> GetEstudiantes()
        {
            return _estudiantes;
        }
        public Estudiante GetEstudianteporapellido(string apellido)
        {
            Estudiante estudiante = null;
            foreach (Estudiante e in _estudiantes)
            {
                if (e.Apellido == apellido)
                {
                    estudiante = e;
                }
            }
            

            if (estudiante == null)
            {
                throw new Exception("El estudiante no existe.");
            }
            return estudiante;
        }
        public void CargarInscripcion(Inscripcion inscripcion)
        {
            try
            {
                if (inscripcion.Estudiante is EstudianteRecursante)
                {
                    EstudianteRecursante recursante = (EstudianteRecursante)inscripcion.Estudiante;
                    if (recursante.CantidadCursosTomados >= 3)
                    {
                        throw new EstudianteInhabilitadoException();
                    }
                }
                else
                {
                    foreach (Inscripcion i in _inscripciones)
                    {
                        if (inscripcion.Estudiante == i.Estudiante && inscripcion.Materia == i.Materia)
                        {
                            throw new EstudianteInscriptoException();
                        }
                    }

                    

                }
                _inscripciones.Add(inscripcion);
            }
            catch(Exception ex)
            {
                throw new Exception("No se puede cargar la inscripción");
            }
           

        }
        public List<Inscripcion> GetInscripcionesPorFecha( DateTime fecha)
        {
            List<Inscripcion> ins = null;
            foreach( Inscripcion i in _inscripciones)
            {
                if( i.FechaInscripcion== fecha)
                {
                    ins.Add(i);
                }
            }
            return ins;
        }
        
    }
}
