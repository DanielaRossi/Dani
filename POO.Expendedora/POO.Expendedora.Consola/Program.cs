using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Expendedora.Biblioteca;
using POO.Expendedora.Utilidad;
using POO.FACULTAD.CONSOLAUTILS;



namespace POO.Expendedora.Consola
{
    class Program
         

    {
        static bool _consolaActiva;
        static Program()
        {
            _consolaActiva = true;
        }
        
        static void Main(string[] args)
        {
            

            Expendedor expendedora = new Expendedor();
                
            
           
            while (_consolaActiva)
            {
                DesplegarMenu();
                string opcionMenu = Console.ReadLine();
                bool encendido = false;
                
                switch (opcionMenu)
                {
                    case "0":

                        Program.Encender(expendedora);
                        Console.WriteLine("Bienvenido.");
                        break;
                    case "1":
                        Program.ListarLatas(expendedora);
                        break;
                    case "2":
                        
                        
                            Program.IngresarLata(expendedora);
                        
                        break;

                }
            }

        }
        private static void Encender(Expendedor expendedora)
        {
            expendedora.EncenderMaquina();
        }
        private static void ListarLatas(Expendedor expendedora)
        {
            if (expendedora.TraerLatas().Any())
            {
                foreach (Lata e in expendedora.TraerLatas())
                {
                    Console.WriteLine(e.ToString());
                }
            }
            if (expendedora.TraerLatas() == null)
            {
                Console.WriteLine("No existen latas en la lista.");
            }
        }


        private static void IngresarLata(Expendedor expendedora)
        {
            try
            {
                string codigo = ConsolaUtils.PedirString("Codigo");
              
                string nombre = ConsolaUtils.PedirString("Nombre");
                string sabor = ConsolaUtils.PedirString("Sabor");
                double precio = ConsolaUtils.PedirDouble("Precio");
                double volumen = ConsolaUtils.PedirDouble("Volumen");
                int cantidad = ConsolaUtils.PedirInt("Cantidad");
                expendedora.AgregarLata(codigo, nombre, sabor, precio, volumen, cantidad);
                Console.WriteLine("Alumno agregado");
            }
            catch(Elcodigoyaexiste ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(LaMaquinaestallena ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible ingresar la lata."+ ex.Message);
            }
        }
        //private static void ExtraerLata(Expendedora)
        //{

        //}
        //private static void ObtenerBalance(Expendedora)
        //{

        //}
        //private static void MostrarStock(Expendedora)
        //{

        //}
        static void DesplegarMenu()
        {
            Console.WriteLine("0. Encender");
            Console.WriteLine("1. Mostrar listado de latas");
            Console.WriteLine("2. Ingreso de latas de bebida");
            Console.WriteLine("3. Extracción de lata");
            Console.WriteLine("4. Balance");
            Console.WriteLine("5. Stock y descripciòn");


        }

    }
}
