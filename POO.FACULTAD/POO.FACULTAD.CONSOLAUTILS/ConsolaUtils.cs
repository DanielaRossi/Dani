using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.CONSOLAUTILS
{
    public static class ConsolaUtils
    {

        public static string PedirString(string mensaje)
        {
            Console.WriteLine("Ingrese" + mensaje);
            string valor = Console.ReadLine();
            return valor;
        }
        public static bool EsOpcionValida(string opcionSeleccionada, string [] opcionesValidas)
        {
            if(opcionSeleccionada == opcionesValidas [9])
            {
                
                return true;
            }
            return false;
            
        }
        


    }
}
