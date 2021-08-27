using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.PrimeraClase.Validación;
using Cuatri2021.PrimeraClase.Calculadora;


namespace Cuatri._2021.PrimeraClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Ingrese un numero: ");
            string Ingresousuario = Console.ReadLine();
            int NumeroIngresado = Convert.ToInt32(Ingresousuario);
            
            
            bool esValido = Validador.EsValido(NumeroIngresado);

            if (esValido)
            {
                Console.WriteLine("Es valido.");
            }
            else
            {
                Console.WriteLine("No es valido.");

            }
            ClaseCalculadora C = new ClaseCalculadora();
            C.Pedidodedatos();
            //C.Operación(2, 4, "+");
        } 
    }


}
        
    

