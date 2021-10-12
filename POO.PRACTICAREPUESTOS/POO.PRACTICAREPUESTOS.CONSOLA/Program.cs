using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.PRACTICAREPUESTOS.BIBLIOTECA.Entidades;
using POO.PRACTICAREPUESTOS.BIBLIOTECA.Utilidades;

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
            string menu = "1) Listar repuestos\n 2)Agregar repuestos\n 3) Listarrepuestos por categorìa \n4)Eliminar repuestos\n 5)Salir \n6) ModificarPrecio\n7) Repuestospor categorìa";
             

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
                        Listarrepuestosporcategoria();
                        break;
                    case "4":
                        EliminarRepuestos();
                        break;
                    case "5":
                        _consolaActiva = false;
                        break;
                    case "6":
                        ModPrecio();
                        break;
                    case "7":
                        RepuestosPorCategoria();
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
            try
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

                Categoria cat = new Categoria(codigocategoria, nombrecategoria);
                //Categoria c = CategoriaHelper.GetCategorias();
                // Crear repuesto

                ventarepuesto.AgregarRepuesto(codigo, nombre, precio, stock, cat);
            }
            catch(Exception ex)
            {

            }
            

            
            
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
        private static void EliminarRepuestos()
        {
            List<Repuesto> lst = ventarepuesto.TraerRepuestos();

            if (lst!= null)
            {
                Listarrepuestos();
                Console.WriteLine("Seleccione un codigo de la lista a eliminar");

                try
                {
                    Console.WriteLine("Ingrese el codigo del repuesto que quiere eliminar: ");
                    int codigo = ConsolaHelper.PedirInt();
                    
                    ventarepuesto.QuitarRepuesto(codigo);
                    Console.WriteLine("Alumno eliminado");

                }
                catch (Elalumnofueencontrado ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("No es posible eliminar el repuesto.");
                }
            }
            else 
            {
                Console.WriteLine("No hay elementos en la lista para eliminar.");
            }
        }
        private static void Listarrepuestosporcategoria()
        {
            
        }
        private static void RepuestosPorCategoria()
        {
            Console.WriteLine("Ingrese una categoria");

            int cat = int.Parse(Console.ReadLine());

            List<Repuesto> lst = ventarepuesto.TraerRepuestosPorCategoria(cat);

            foreach (Repuesto r in lst)
            {
                Console.WriteLine(r.Nombre);
            }
        }

        private static void ListarCategorias()
        {
            List<Categoria> todas = CategoriaHelper.GetCategorias();
            foreach (Categoria k in todas)
            {
                Console.WriteLine($"{k.Codigo}) {k.Nombre}");
            }
        }
        private static void ModPrecio()
        {
            Console.WriteLine("Ingrese un codigo");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo precio");
            double precio = Convert.ToDouble(Console.ReadLine());
            ventarepuesto.ModificarPrecio(codigo, precio);
        }


    }
}
