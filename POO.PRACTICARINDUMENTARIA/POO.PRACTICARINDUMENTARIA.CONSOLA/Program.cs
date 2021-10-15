using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad;
//using POO.PRACTICARINDUMENTARIA.NEGOCIO.EXCEPCIONES;
//using POO.PRACTICARINDUMENTARIA.NEGOCIO.ENUM;
using POO.PRACTICARINDUMENTARIA.CONSOLAUTILS;
using Libreria;

namespace POO.PRACTICARINDUMENTARIA.CONSOLA
{
    class Program
    {
        static TiendaRopa _tiendaropa;
        
        static Program()
        {
            _tiendaropa =  new TiendaRopa();
            
        }
        
        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;
            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar indumentaria \n2) Agregar indumentaria\n 3)Agregar Alumno \n 4)Modificar Alumno \n 5)Eliminar Alumno \n 6)Agregar Empleado \n7) Modificar empleado \n8)Eliminar Empleado \n9)Borrar ";
            // Creo el objeto con el que voy a trabajar en este programa
            //TiendaRopa _tiendaropa = new TiendaRopa();
            // pantalla de bienvenida
            
            do
            {
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                //String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "X" };
                //if (ConsolaUtils.EsOpcionValida(opcionSeleccionada, opcionesValidas))
                //{
                //if (opcionSeleccionada.ToUpper() == "X")
                //{
                //    continuarActivo = false;
                //    continue;
                //}
                switch (opcionSeleccionada)

                {
                    case "1":
                        // listar
                        Program.GetDetalle();
                        break;
                    case "2":
                        // listar
                        Program.AgregarIndumentaria();
                        break;
                    case "3":
                    //    // alta
                    //    Program.AgregarAlumno(facultad);
                    //    break;
                    //case "4":
                    //    // modificar
                    //    Program.ModificarAlumno(facultad);
                    //    break;
                    //case "5":
                    //    // borrar
                    //    Program.EliminarAlumno(facultad);
                    //    break;
                    //case "6":
                    //    // alta
                    //    Program.AgregarEmpleado(facultad);
                    //    break;
                    case "7":
                        // modificar
                        //Program.ModificarAlumno(facultad);
                        break;
                    case "8":
                        // borrar
                        //Program.EliminarEmpleado(facultad);
                        break;
                    case "9":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                //}
                //else
                //{
                //    Console.WriteLine("Opción inválida.");
                //}
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }
        public static void GetDetalle()
        {
            if (_tiendaropa.Listar().Any())
            {
                foreach (Indumentaria i in _tiendaropa.Listar())
                {
                    Console.WriteLine(i.GetDetalle());
                }
            }
            else
            {
                Console.WriteLine("No hay indumentaria.");
            }
        }
        public static void AgregarIndumentaria()
        {
            try
            {
                Console.WriteLine("Ingrese una camisa:");
                
                int codigo = Validacion.PedirInt("Codigo");
                int stock = Validacion.PedirInt("Stock");
                string talle = Validacion.PedirString("Talle");
                double precio = Validacion.PedirDouble("Precio");
                string orden = Validacion.PedirString("Orden");
                //string orden2 = ConsolaUtils.PedirString("Orden");
                double porcentajealgodon = Validacion.PedirDouble("Porcentaje algodon");
                bool estampado = Validacion.PedirBool("Estampado");
                string manga = Validacion.PedirString("Tipo de manga");

                TipoIndumentaria t = new TipoIndumentaria(orden, porcentajealgodon);
                //Camisa camisaNegra = new Camisa(codigo, stock, talle, precio, t, estampado, manga);

                //Indumentaria indumentaria = camisaNegra;
                //_tiendaropa.AgregarCamisa(indumentaria);
                
                _tiendaropa.AgregarCamisa(codigo, stock, talle, precio, t, estampado, manga);
                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    }

