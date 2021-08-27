using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.PrimeraClase.Calculadora
{
    public class ClaseCalculadora
    {
        float num1;
        float num2;
        
        string op;
        public void Pedidodedatos()
        {
            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Que operación desea realizar: suma(+),resta(-), multiplicación(*) o división(/) ");
            op = Console.ReadLine();
            
            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            float resultado = 0;

            if (op == "+")
            {
                resultado = num1 + num2;
            }
            else if (op == "-")
            {
                resultado = num1 - num2;
            }
            else if (op == "*")
            {
                resultado = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("No es posible dividir por cero.");
                }
                else
                {
                    resultado = num1 / num2;
                }
            }
            Console.WriteLine("El resultado es: " + resultado);





        }



        }


    }

