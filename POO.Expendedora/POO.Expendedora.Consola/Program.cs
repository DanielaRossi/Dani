using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Expendedora.Biblioteca;


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
            Lata lata = new Lata();

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

                    case "2":
                        if (encendido == false)
                        {
                            Console.WriteLine("Primero debe encender la maquina.");
                        }
                        else
                        {
                            Program.IngresarLata();
                        }
                        break;

                }
            }

        }
        private static void Encender(Expendedor expendedora)
        {
            expendedora.EncenderMaquina();
        }


        //private static void IngresarLata(Expendedora)
        //{
            
        //}
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
