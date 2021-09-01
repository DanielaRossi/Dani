using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.almacen.biblioteca;

namespace POO.Almacen.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto P1 = new Producto();
            P1._StockProducto = 12;
            Console.WriteLine("El stock es: " + P1._StockProducto);
            P1.Venta();
            P1.ReponerStock();
            Console.WriteLine("El stock es: " + P1._StockProducto);
            P1.Venta();
            P1.Venta();
            P1.ReponerStock();
            Console.WriteLine("El stock es: " + P1._StockProducto);

            Console.ReadLine();
        }
    }
}
