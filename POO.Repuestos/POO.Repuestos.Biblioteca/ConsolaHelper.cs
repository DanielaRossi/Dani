using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Repuestos.Biblioteca
{
    public class ConsolaHelper
    {
        public static string PedirString()
        {
            
            return Console.ReadLine();
        }

        public static int PedirInt()
        {
            
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
