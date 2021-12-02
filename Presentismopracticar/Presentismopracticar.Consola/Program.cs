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
        static Program()
        {
            _presentismo = new Presentismo();
            _consolaActiva = true;
        }
        static void Main(string[] args)
        {
            while (_consolaActiva)
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
                List<Alumno> lst = _presentismo.GetListaAlumnos(fecha);
                // para cada alumno solo preguntar si está presente
                List<Asistencia> asistenciasLista = new List<Asistencia>();
                foreach (Alumno l in lst)
                {
                    if (l is AlumnoOyente)
                    {
                        Console.WriteLine(l.ToString());
                        Console.WriteLine("El alumno es oyente.");
                    }
                    else
                    {

                        Console.WriteLine(l.ToString());
                        string presente = Validaciones.PedirString("si está presente");
                        bool presentebool = Convert.ToBoolean(presente);

                        Asistencia a = _presentismo.Agregar(fecha, p, l, presentebool);
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
                _presentismo.GetAsistenciasPorFecha(fecha);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
