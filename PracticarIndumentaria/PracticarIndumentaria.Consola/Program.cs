using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaUtils;
namespace PracticarIndumentaria.Consola
{
    public class Program
    {
        private static TiendaRopa _tiendaropa;
        static bool _consolaActiva;

        public static object Validaciones { get; private set; }

        static Program()
        {
            _tiendaropa = new TiendaRopa(1);
            _consolaActiva = true;
        }
        static void Main(string[] args)
        {
            
            while (_consolaActiva)
            {



                DesplegarOpcionesMenu();
                string opcionMenu = Validar.PedirString("una opcion");
                switch (opcionMenu)
                {
                    case "1":
                        //InscribirEstudiante(profesor);
                        break;
                    case "2":
                        AgregarIndumentaria();
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
            Console.WriteLine("1) Listar Indumentarias");
            Console.WriteLine("2) Agregar indumentarias");
            Console.WriteLine("3) Modificar Indumentarias");
            Console.WriteLine("4) Eliminar indumentarias");
            Console.WriteLine("5) Listar ordenes");
            Console.WriteLine("2) Devolver orden");
            Console.WriteLine("X: Terminar");
        }
        private void AgregarIndumentaria()
        {

        }
    }
