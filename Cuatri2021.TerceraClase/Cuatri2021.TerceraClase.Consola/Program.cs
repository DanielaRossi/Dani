﻿using System;
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
            

            Console.WriteLine("Hago correr a p1, su estado fìsico es" , p1.PorcentajeEstadoFisico.ToString());
            p1.Correr();
            Console.WriteLine("Hago correr a p1, su estado fìsico es", p1.PorcentajeEstadoFisico.ToString());

            if(p1.EstaCansado())
            {
                Console.WriteLine(p1.Nombre + "esta cansado");
            }

            else
            {
                Console.WriteLine(p1.Nombre + "no esta cansado");
            }
            
            int valor = p1.Multiplicador(2);

            Console.WriteLine(p1.Domicilio);
        }
    }
}
