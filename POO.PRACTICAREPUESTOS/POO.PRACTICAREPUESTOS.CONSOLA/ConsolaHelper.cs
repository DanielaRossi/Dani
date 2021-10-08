using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICAREPUESTOS.CONSOLA
{
    public class ConsolaHelper
    {
        internal static string PedirString()
        {
            // SE DEBE VALIDAR
            return Console.ReadLine();
        }

        internal static int PedirInt()
        {
            // SE DEBE VALIDAR
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static double PedirDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
