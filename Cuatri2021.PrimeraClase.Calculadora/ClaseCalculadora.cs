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
        float resultado = 0;
        
        public void Pedidodedatos()
        {
            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Que operación desea realizar: suma(+),resta(-), multiplicación(*) o división(/) ");
            string operador = Console.ReadLine();
            
            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            

            if (operador == "+")
            {
                resultado = num1 + num2;
                
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }

            else if (operador == "*")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
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
            Console.WriteLine(resultado);
            





        }



        }


    }

