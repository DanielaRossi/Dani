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
        public void Ejercicio8()
        {
            DateTime Dia;
            int Diferencia;
            Console.Write("Por favor, ingrese una fecha: ");
            Dia = Convert.ToDateTime(Console.ReadLine());
            


        }
        public void Ejercicio9()
        {
            string Nombre;
            Console.Write("Por favor, ingrese su nombre: ");
            Nombre = Console.ReadLine();

            if(string.IsNullOrEmpty(Nombre))
            {
                Console.WriteLine("No te conozco.");
            }
            else
            {
                Console.WriteLine("Hola, " + Nombre);
            }
        }
        public void Ejercicio13()
        {
            int Numero;
            Console.Write("Por favor, ingrese un numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());

        }
        public void Ejercicio16()
        {
            int Numero;
            int Digitos = 1;
            
            Console.Write("Por favor, ingrese un numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            int Numeroingresado = Numero;
            while (Numero >= 10)
            {
                Numero /= 10;
                Digitos++;
            }
            Console.WriteLine("Nùmero ingresado: "+Numeroingresado+"-"+ Digitos + " digitos.");
        }
            
    }
}
