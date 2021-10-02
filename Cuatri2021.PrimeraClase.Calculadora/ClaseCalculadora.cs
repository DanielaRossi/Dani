using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.PrimeraClase.Calculadora
{
    public class ClaseCalculadora
    {


        public void Pedidodedatos(ref float resultado, float num1, float num2, string operador)
        {
            
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



        }




    }


    }

