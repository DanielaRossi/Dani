using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.SegundaClase.Biblioteca;



namespace Cuatri2021.SegundaClase.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara variable cliente ejemplo de tipo cliente bancario
            Cliente clienteEjemplo;
            //instanciar clase 
            clienteEjemplo = new Cliente();

            clienteEjemplo.NumeroDocumento = 1234;
        }
    }
}
