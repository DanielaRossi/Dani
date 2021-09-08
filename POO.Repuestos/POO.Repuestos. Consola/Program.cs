using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Repuestos.Biblioteca;

namespace POO.Repuestos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenida" + _ventarepuestos.NombreComercio);
            while (_consolaActiva)
            {
                Console.Clear();
                DesplegarMenu();
                string opciónMenu = Console.ReadLine();

                switch (opciónMenu)
                {
                    case "1":
                        Listarrepuestos();
                        break;
                    case "2":
                        break;
                    case "x":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");
                            break;
                }
            }
        }
        static void DesplegarMenu()
        {
            Console.WriteLine("1) ; 1");
            Console.WriteLine("2) ; 1");
            Console.WriteLine("x ; Terminar");

        }
        static bool _consolaActiva;
        static VentaRepuestos _ventarepuestos;
        static Program()
        {
            _consolaActiva = true;
            _ventarepuestos = new VentaRepuestos("Todo repuestos", "Cabildo 200");
        }
        private static void Listarrepuestos()
        {
            List<Repuesto> lst = _ventarepuestos.Traerrepuestos();
            if(lst != null)
            {
                foreach(Repuesto repuesto in lst)
                {
                    Console.WriteLine(repuesto.Código + repuesto.Nombre);
                }
                
            }
            else
            {
                Console.WriteLine("Aún no hay repuestos cargados.")
            }

        }
    }
}
