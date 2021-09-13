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
                        Agregarrepuestos();
                        break;
                    case "x":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");
                            break;
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadLine();
            }
        }
        static void DesplegarMenu()
        {
            Console.WriteLine("1)Listar repuestos");
            Console.WriteLine("2) Agregar repuestos");
            Console.WriteLine("x Terminar");

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
                    Console.WriteLine(repuesto.Código + repuesto.Nombre+ repuesto.Precio+ repuesto.Stock+ repuesto.CategoriaCompleta);
                }
                
            }
            else
            {
                Console.WriteLine("Aún no hay repuestos cargados.");
            }

        }
        private static void Agregarrepuestos()
        {
            Console.WriteLine("Ingrese el código del repuesto: ");
            int código = ConsolaHelper.PedirInt();
            Console.WriteLine("Ingrese el nombre del repuesto: ");
            string nombre = ConsolaHelper.PedirString();
            //Console.WriteLine("Ingrese el precio: ");
            //double precio = (Convert.ToBase64String(Console.ReadLine));
            Console.WriteLine("Ingrese el stock: ");
            int stock = ConsolaHelper.PedirInt();

            Repuesto re = new Repuesto(código, nombre, 0, stock);

            // Alta de repuestos //No se
            bool resultado = _ventarepuestos.AgregarRepuesto(re);

            if (resultado)
            {
                Console.WriteLine("Repuesto agregado.");
            }
            else
            {
                Console.WriteLine("Error al agregar el repuesto.");

            }

        }
    }
}
