﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.CONSOLAUTILS
{
    public static class ConsolaUtils
    {
        //public static string PedirString(string mensaje)
        //{
        //    Console.WriteLine("Ingrese" + mensaje);
        //    string valor = Console.ReadLine();
        //    return valor;
        //}

        public static int PedirInt(string mensaje)
        {
            Console.WriteLine("Ingrese" + mensaje);
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }
        public static double PedirDouble(string mensaje)
        {
            Console.WriteLine("Ingrese" + mensaje);
            double valor = Convert.ToDouble(Console.ReadLine());
            return valor;
        }
        public static DateTime PedirFecha(string mensaje)
        {
            Console.WriteLine("Ingrese" + mensaje);
            DateTime valor = Convert.ToDateTime(Console.ReadLine());
            return valor;
        }
        public static bool ValidarInt(string input)
        {
            return true;
        }
        public static int ConvertirNumero(string valor)
        {
            int res = Convert.ToInt32(valor);

            return res;
        }
        public static string PedirString(string mensaje)
        {
            bool flag = true;
            string valor;
            do
            {
                Console.WriteLine("Ingrese" + mensaje);
                valor = Console.ReadLine();
                flag = ValidarVacio(valor);
            } while (flag == false);

            return valor;
            
        }
        public static bool ValidarVacio(string valor)
        {
            bool flag= true;
            if (string.IsNullOrEmpty(valor))
            {
                flag = false;
            }
            return flag;
        }
    }
}
