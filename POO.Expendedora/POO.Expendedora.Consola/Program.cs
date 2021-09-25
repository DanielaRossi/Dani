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
                        if (encendido == false)
                        {
                            Console.WriteLine("Primero debe encender la maquina.");
                        }
                        else
                        {
                            Program.IngresarLata(expendedora);
                        }
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
                int codigo = ConsolaUtils.PedirInt("Codigo")
                string nombre = ConsolaUtils.PedirString("Nombre");
                string apellido = ConsolaUtils.PedirString("Apellido");
                DateTime fechanacimiento = ConsolaUtils.PedirFecha("Fecha de Nacimiento");
                facultad.AgregarAlumno(codigo, apellido, nombre, fechanacimiento);
                Console.WriteLine("Alumno agregado");
            }
            catch (Exception ex)
            {

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
