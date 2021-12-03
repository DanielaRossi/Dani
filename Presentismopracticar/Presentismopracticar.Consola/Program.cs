using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaUtils;

namespace Presentismopracticar.Consola
{
    public class Program
    {
        static  bool _consolaActiva;
        private static Presentismo _presentismo;
        //static List<Asistencia> _asistencias;
        //static List<Alumno> _alumnos;
        static Program()
        {
            _presentismo = new Presentismo();
            _consolaActiva = true;
            
        }
        static void Main(string[] args)
        {
            while (_consolaActiva)
            {

                try
                {
                    Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();



                    DesplegarOpcionesMenu();
                    string opcionMenu = Validaciones.PedirString("una opción de menù");
                    switch (opcionMenu)
                    {
                        case "1":
                            TomarAsistencia(preceptorActivo);
                            break;
                        case "2":
                            MostrarAsistencia();
                            break;
                        case "X":
                            _consolaActiva = false;
                            break;
                        default:
                            Console.WriteLine("Opciòn incorrecta.");
                            break;
                    }
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            try
            {


                // Ingreso fecha
                //string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime fechaN = Validaciones.PedirFecha("una fecha");
                string fecha = fechaN.ToString("yyyy-MM-dd");

                // Listar los alumnos
                List<Alumno> _alumnos = new List<Alumno>();
                _alumnos = _presentismo.GetListaAlumnos(fecha);


                // para cada alumno solo preguntar si está presente
                List<Asistencia> asistenciasLista = new List<Asistencia>();
                foreach (Alumno l in _alumnos)
                {
                    if (l is AlumnoOyente)
                    {
                        Console.WriteLine(l.ToString());
                        Console.WriteLine("El alumno es oyente.");
                    }
                    else
                    {

                        Console.WriteLine(l.ToString());
                        
                        bool presentebool = Validaciones.PedirBool("si está presente o no");


                        Asistencia a = new Asistencia(fecha, p, l, presentebool);

                        asistenciasLista.Add(a);



                        

                    }
                }
                // agrego la lista de asistencia
                _presentismo.AgregarAsistencia(asistenciasLista, fecha);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            try
            {
                // ingreso fecha
                DateTime fechaN = Validaciones.PedirFecha("una fecha");
                string fecha = fechaN.ToString("yyyy-MM-dd");
                // muestro el toString de cada asistencia
                List<Asistencia> _asistencias = new List<Asistencia>();
                _asistencias = _presentismo.GetAsistenciasPorFecha(fecha);
                foreach(Asistencia a in _asistencias)
                {
                    Console.WriteLine(a.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //try
            //{
            //    DateTime fecha = Validaciones.PedirFecha("una fecha");
            //    string fechaS = fecha.ToString("yyyy-MM-dd");

            //    _asistencias= _presentismo.GetAsistenciasPorFecha(fechaS);
            //    foreach(Asistencia a in _asistencias)
            //    {
            //        Console.WriteLine(a.ToString());
            //    }
            //}
            
        }
    }
}
