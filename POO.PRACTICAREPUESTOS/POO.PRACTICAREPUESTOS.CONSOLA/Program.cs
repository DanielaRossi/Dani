using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.PRACTICAREPUESTOS.BIBLIOTECA.Entidades;

namespace POO.PRACTICAREPUESTOS.CONSOLA
{
    class Program
    {
        static VentaRepuesto ventarepuesto;
        static Program()
        {
            ventarepuesto = new VentaRepuesto("Dagu", "Pedro Moran");
        }
        static void Main(string[] args)
        {
            bool _consolaActiva = true;
            string menu = "1) Listar repuestos\n 2)Agregar repuestos\n 3) Listarrepuestos por categorìa \n 4)Salir \n";
             

            Console.WriteLine("Bienvenida a " + ventarepuesto.NombreComercio);

            do
            {
                Console.WriteLine(menu);
                string opcionmenu = Console.ReadLine();
                switch (opcionmenu)
                {
                    case "1":
                        Listarrepuestos();
                        break;
                    case "2":
                        Agregarrepuesto();
                        break;
                    case "3":
                        break;
                    case "4":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opciòn incorrecta.");
                        break;

                }

                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadLine();
            }
            while (_consolaActiva);
        }
        private static void Agregarrepuesto()
        {
            Console.WriteLine("Ingrese un codigo:");
            int codigo = ConsolaHelper.PedirInt();
            Console.WriteLine("Ingrese un nombre:");
            string nombre = ConsolaHelper.PedirString();
            Console.WriteLine("Ingrese un precio:");
            double precio = ConsolaHelper.PedirDouble();
            Console.WriteLine("Ingrese un stock:");
            int stock = ConsolaHelper.PedirInt();
            Console.WriteLine("Ingrese el nombre de la categoria");
            string nombrecategoria = ConsolaHelper.PedirString();

            Console.WriteLine("Ingrese el codigo de la categoria:");
            int codigocategoria = ConsolaHelper.PedirInt();

            //Crear categoria

            Categoria cat = new Categoria(codigocategoria,nombrecategoria);
            // Crear repuesto

            ventarepuesto.AgregarRepuesto(codigo, nombre, precio, stock, cat);
            

            
            
        }
        private static void Listarrepuestos()
        {
            List<Repuesto> lst = ventarepuesto.TraerRepuestos();
                
                if (lst != null)
                {
                    foreach(Repuesto repuesto in lst)
                    {
                        Console.WriteLine("Codigo:" + repuesto.Codigo + "Nombre" + repuesto.Nombre + "Precio: " + repuesto.Precio + "Stock: " + repuesto.Stock + "Categoria" + repuesto.Categoria);
                    }
                }
                else
                {
                    Console.WriteLine("No hay elementos en la lista.");
                }
            
        }
    }
}
