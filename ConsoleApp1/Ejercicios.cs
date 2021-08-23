using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ejercicios
    {
        public void Ejercicio3()
        {
            string Palabra;
            Console.Write("Por favor, ingrese una palabra:");
            Palabra = Console.ReadLine();
        }
        public void Ejercicio6()
        {
            int Numero1;
            int Numero2;
            int Resultado;
            Console.Write("Por favor, ingrese un numero: ");
            Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor, ingrese un numero: ");
            Numero2 = Convert.ToInt32(Console.ReadLine());
            Resultado = (Numero1 + Numero2) * (Numero1 - Numero2);
            Console.WriteLine("El resultado es: " + Resultado);

        }
    }
}
