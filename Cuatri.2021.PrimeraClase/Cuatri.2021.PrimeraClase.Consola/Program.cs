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
            //    Console.WriteLine("Hola Mundo");
            //    Console.WriteLine("Ingrese un numero: ");
            //    string Ingresousuario = Console.ReadLine();
            //    int NumeroIngresado = Convert.ToInt32(Ingresousuario);


            //    bool esValido = Validador.EsValido(NumeroIngresado);

            //    if (esValido)
            //    {
            //        Console.WriteLine("Es valido.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No es valido.");

            //    }
            ClaseCalculadora C = new ClaseCalculadora();

            float resultado = 0;
            float num1;
            float num2;
            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Que operación desea realizar: suma(+),resta(-), multiplicación(*) o división(/) ");
            string operador = Console.ReadLine();

            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            C.Pedidodedatos(ref resultado, num1, num2, operador);
            Console.WriteLine("El resultado es:" + resultado);
            Console.Read();
            //C.Operación(2, 4, "+");
        } 
    }


}
        
    

