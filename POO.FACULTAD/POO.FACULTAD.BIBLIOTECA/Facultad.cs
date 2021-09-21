using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Facultad
    {
        private string _nombre;
        private int _cantidadSedes;
        private List<Alumno> _alumnos;
        private List<Empleado> _empleados;

        public int CantidadSedes { get => _cantidadSedes; set => value = _cantidadSedes; }

        public string Nombre { get => _nombre; set => value = _nombre; }

        public Facultad(string Nombre)
        {
            this._nombre = Nombre;
            this._alumnos = new List<Alumno>();
            this._empleados = new List<Empleado>();
        }



        //public static void AgregarAlumno(Alumno)
        //{

        //}
        //public static void AgregarEmpleado(Empleado)
        //{

        //}
        //public static void EliminarAlumno(int)
        //{

        //}
        //public static void EliminarEmpleado(int)
        //{

        //}
        //public static void ModificarEmpleado(Empleado)
        //{

        //}
        public List<Alumno> TraerAlumnos()
        {
            if (_alumnos.Count == 0)
            {
                return null;
            }
            else
            {
                return _alumnos;
            }
            
        }
        //public static Empleado TrerEmpleadoPorLegajo(int)
        //{
        //    return
        //}
        //public static List<Empleado> TraerEmpleados()
        //{
        //    return
        //}
        //public static List<Empleado> TrearEmpleadosPorNombre(string)
        //{
        //    return
        //}

    }
}
