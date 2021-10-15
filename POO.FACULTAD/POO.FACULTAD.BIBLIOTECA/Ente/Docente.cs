using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Docente : Empleado
    {
        //public Docente() : base(fechaingreso, legajo)
        //{

        //}


        //public override string GetNombreCompleto()
        //{
        //    return ";
        //}
        public Docente(string apellido, string nombre, DateTime fechanacimiento, int legajo, DateTime fechaingreso) : base(apellido, nombre, fechanacimiento, legajo, fechaingreso)
        {

        }

    }
}
