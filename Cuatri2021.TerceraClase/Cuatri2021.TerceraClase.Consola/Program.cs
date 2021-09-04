using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.TerceraClase.Biblioteca;


namespace Cuatri2021.TerceraClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Daniela";
            Console.WriteLine(p1.Nombre);
        }
    }
}
