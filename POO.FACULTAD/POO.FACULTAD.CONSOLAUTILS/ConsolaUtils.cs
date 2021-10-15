using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.CONSOLAUTILS
{
    public static class ConsolaUtils
    {

        //public static string PedirString(string mensaje)
        //{
        //    Console.WriteLine("Ingrese" + mensaje);
        //    string valor = Console.ReadLine();
        //    return valor;
        //}

        //public static int PedirInt(string mensaje)
        //{
        //    Console.WriteLine("Ingrese" + mensaje);
        //    int valor = Convert.ToInt32(Console.ReadLine());
        //    return valor;
        //}
        //public static double PedirDouble(string mensaje)
        //{
        //    Console.WriteLine("Ingrese" + mensaje);
        //    double valor = Convert.ToDouble(Console.ReadLine());
        //    return valor;
        //}
        //public static DateTime PedirFecha(string mensaje)
        //{
        //    Console.WriteLine("Ingrese" + mensaje);
        //    DateTime valor = Convert.ToDateTime(Console.ReadLine());
        //    return valor;
        //}
        //public static bool ValidarInt(string input)
        //{
        //    return true;
        //}
        //public static int ConvertirNumero(string valor)
        //{
        //    int res = Convert.ToInt32(valor);

        //    return res;
        //}
        ////public static bool EsOpcionValida(string opcionSeleccionada, string [] opcionesValidas)
        ////{
        ////    if(opcionSeleccionada == opcionesValidas [9])
        ////    {

        ////        return true;
        ////    }
        ////    return false;

        ////}

        public static string PedirString(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                valor = Console.ReadLine();
                flag = ValidarVacio(valor);
            } while (flag == false);

            return valor;

        }
        public static bool ValidarVacio(string valor)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("No ingreso ningun dato. Por favor ingrese el dato.");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public static int PedirInt(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                valor = Console.ReadLine();
                flag = ValidarInt(valor);
            } while (flag == false);

            return Convert.ToInt32(valor);

        }
        public static bool ValidarInt(string valor)
        {
            bool flag = false;
            if (!int.TryParse(valor, out int Salida))
            {
                Console.WriteLine("El valor ingresado no es numerico.");
            }
            else if (Salida <= 0)
            {
                Console.WriteLine("El valor ingresado debe ser positivo.");
            }

            else
            {
                flag = true;
            }
            return flag;
        }
        public static double PedirDouble(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                valor = Console.ReadLine();
                flag = ValidarDouble(valor);
            } while (flag == false);

            return Convert.ToDouble(valor);

        }
        public static bool ValidarDouble(string valor)
        {
            bool flag = false;
            if (!double.TryParse(valor, out double Salida))
            {
                Console.WriteLine("El valor ingresado no es numerico.");
            }
            else if (Salida <= 0)
            {
                Console.WriteLine("El valor ingresado debe ser positivo.");
            }

            else
            {
                flag = true;
            }
            return flag;
        }
        public static DateTime PedirFecha(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese " + mensaje);
                valor = Console.ReadLine();
                flag = ValidarFecha(valor);
            } while (flag == false);

            return Convert.ToDateTime(valor);

        }
        public static bool ValidarFecha(string valor)
        {
            bool flag = false;
            if (!DateTime.TryParse(valor, out DateTime Salida))
            {
                Console.WriteLine("El valor ingresado no es una fecha valida.");
            }


            else
            {
                flag = true;
            }
            return flag;
        }
        public static bool PedirBool(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese true o false de " + mensaje);
                valor = Console.ReadLine();
                flag = ValidarBool(valor);
            } while (flag == false);

            return Convert.ToBoolean(valor);

        }
        public static bool ValidarBool(string valor)
        {
            bool flag = false;
            if (!Boolean.TryParse(valor, out Boolean Salida))
            {
                Console.WriteLine("El valor ingresado no es un bool.");
            }


            else
            {
                flag = true;
            }
            return flag;
        }

    }
}
