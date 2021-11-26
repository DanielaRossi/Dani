using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Negocio
{
    public static class Validaciones
    {
        public static void ValidarVacio(string Valor, string Campo)
        {
            if (string.IsNullOrEmpty(Valor))
            {
                throw new Exception("El campo" + Campo + " no debe estar vacio" + System.Environment.NewLine);
            }
        }
        public static void ValidarInt(string Valor, ref int Salida)
        {


            if (!int.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser númerico" + System.Environment.NewLine);
            }
            else if (Salida <= 0)
            {
                throw new Exception("El valor debe ser positivo" + System.Environment.NewLine);
            }
        }
        public static void ValidarDouble(string Valor, ref double Salida)
        {


            if (!double.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser númerico" + System.Environment.NewLine);
            }
            else if (Salida <= 0)
            {
                throw new Exception("El valor debe ser positivo" + System.Environment.NewLine);
            }
        }
        public static void ValidarLong(string Valor, ref long Salida)
        {


            if (!long.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser númerico" + System.Environment.NewLine);
            }
            else if (Salida <= 0)
            {
                throw new Exception("El valor debe ser positivo" + System.Environment.NewLine);
            }
        }
        public static DateTime ValidarFecha(string Valor, ref DateTime Salida)
        {


            if (!DateTime.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser una fecha" + System.Environment.NewLine);
            }
            return Salida;

        }
        public static DateTime ValidarFechaMayorquehoy(string Valor, ref DateTime Salida)
        {


            if (!DateTime.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser una fecha" + System.Environment.NewLine);
            }
            else if(Salida> DateTime.Now)
            {
                throw new Exception("El valor debe ser una fecha mayor al día de hoy" + System.Environment.NewLine);
            }
            return Salida;

        }


    }
}
