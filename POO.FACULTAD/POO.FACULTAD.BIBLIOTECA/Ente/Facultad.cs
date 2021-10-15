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

        

        public void AgregarAlumno(int codigo, string apellido, string nombre, DateTime fechanacimiento)
        {
            Alumno alumno = new Alumno(codigo, apellido, nombre, fechanacimiento);
            AgregarAlumno(alumno);
        }
        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }
        //public void AgregarEmpleado(string apellido, string nombre, DateTime fechanacimiento, int legajo, DateTime fechaingreso)
        //{
        //    Empleado empleado = new Empleado(apellido, nombre, fechanacimiento, legajo, fechaingreso);
        //    AgregarEmpleado(empleado);
        //}

        public void AgregarEmpleado(Empleado e)
        {
            _empleados.Add(e);
        }
        public void EliminarAlumno(int codigo)
        {
            Alumno A= _alumnos.Find(Al => Al.Codigo == codigo);
            
            _alumnos.Remove(A);
            
        }
        public void BuscarAlumno( int codigo)
        {
            Alumno A = _alumnos.Find(Al => Al.Codigo == codigo);
            
        }
        
        //public static void EliminarEmpleado(int)
        //{

        //}
        //public static void ModificarEmpleado(Empleado)
        //{

        //}
        public void ModificarAlumno(Alumno alumno)
        {

        }
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
        public List<Empleado> TraerEmpleados()
        {
            if (_empleados.Count == 0)
            {
                return null;
            }
            else
            {
                return _empleados;
            }
            
        }
        public void ObternerBedeles()
        {
            List<Bedel>bedeles = new List<Bedel>();
            foreach (Empleado d in _empleados)
            {
                if (d is Bedel)
                {
                    bedeles.Add((Bedel)d);
                    
                }
            }
        }


        //public static List<Empleado> TrearEmpleadosPorNombre(string)
        //{
        //    return
        //}



    }
}
