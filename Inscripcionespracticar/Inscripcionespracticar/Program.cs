using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscripcionespracticar
{

    public class Program
    {
        private static Instituto _instituto;
        static bool _consolaActiva;
        static List<Estudiante> _estudiantes;
        static List<Materia> _materias;

        static Program()
        {
            _instituto = new Instituto("Nombre");
            _consolaActiva = true;
        }
        static void Main(string[] args)
        {
            //traemos el profesor de turno por legajo (elegir el que quieran)
            Profesor profesor = _instituto.GetProfesor(5);
            while (_consolaActiva)
            {



                DesplegarOpcionesMenu();
                string opcionMenu = Validaciones.PedirString("una opcion");
                switch (opcionMenu)
                {
                    case "1":
                        InscribirEstudiante(profesor);
                        break;
                    case "2":
                        MostrarInscripciones();
                        break;
                    case "X":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadLine();
            }
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Inscribir Estudiante");
            Console.WriteLine("2) Mostrar Inscripciones");
            Console.WriteLine("X: Terminar");
        }
        static void InscribirEstudiante(Profesor p)
        {
            // Listar los estudiantes
            _estudiantes =_instituto.GetEstudiantes();
            // Listar las materias
            _materias= _instituto.GetMaterias();
            // Intento cargar la Inscripción
            // Error: mostrar el error y que luego muestre el menú nuevamente
            try
            {
                
                
                string apellido = Validaciones.PedirString(" su apellido");
                Estudiante estudiante = _instituto.GetEstudianteporapellido(apellido);

               foreach(Materia m in _materias)
                {
                    Console.WriteLine(m.ToString());
                }
                int materiaCodigo = Validaciones.PedirInt(" el codigo de la materia a la que se quiere inscribir");
                Materia materia = _instituto.GetMateriasporcodigo(materiaCodigo);

                
                

                Inscripcion inscripcion = new Inscripcion(p, estudiante, materia);

                _instituto.CargarInscripcion(inscripcion);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void MostrarInscripciones()
        {
            // ingreso fecha
            try
            {
                DateTime fecha = Validaciones.PedirFecha("una fecha");
                // muestro el toString de cada inscripción
                _instituto.GetInscripcionesPorFecha(fecha);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }


    }
}


