using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.REPASOPRESENTISMO.CONSOLAUTILS;
using POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES;
using POO.REPASOPRESENTISMO.NEGOCIO;
using POO.REPASOPRESENTISMO.NEGOCIO.EXCEPCIONES;


namespace POO.REPASOPRESENTISMO.CONSOLA
{
    public class Program
    {

        private static Presentismo _presentismo;
        static bool _consolaActiva;
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
                string opcionMenu = ConsolaUtils.PedirString("Opciòn");
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
                        Console.WriteLine("Opción incorrecta.");
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
            // Ingreso fecha
            // Listar los alumnos
            // para cada alumno solo preguntar si está presente
            // agrego la lista de asistencia
            // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            // ingreso fecha
            // muestro el toString de cada asistencia
        }
    }

}
}
