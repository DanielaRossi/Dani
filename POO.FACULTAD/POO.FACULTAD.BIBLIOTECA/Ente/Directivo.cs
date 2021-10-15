using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Directivo : Empleado
    {
        public string GetNombreCompleto()
        {
            return "Nombre completo del directivo.";
        }
        public Directivo(string apellido, string nombre, DateTime fechanacimiento, int legajo, DateTime fechaingreso) : base(apellido, nombre, fechanacimiento, legajo, fechaingreso)
        {
            
        }
    }
}
