using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.FACULTAD.BIBLIOTECA;
using POO.FACULTAD.CONSOLAUTILS;


namespace POO.FACULTAD.CONSOLA
{
    public class Program
    {
        static Facultad facultad;
        static Program()
        {
            facultad = new Facultad("fce");
        }

        static void Main(string[] args)
        {
            // variables de estado de consola, flag de control de la aplicación
            bool continuarActivo = true;
            // menú que se va a mostrar luego de CADA acción
            string menu = "1) Listar Alumnos \n2) Listar Empleados\n 3)Agregar Alumno \n 4)Modificar Alumno \n 5)Eliminar Alumno \n 6)Agregar Empleado \n7) Modificar empleado \n8)Eliminar Empleado \n9)Borrar ";
            // Creo el objeto con el que voy a trabajar en este programa
            //Facultad facultad = new Facultad("FCE");
            // pantalla de bienvenida
            Console.WriteLine("Bienvenido a " + facultad.Nombre);
            do
            {
                Console.WriteLine(menu); //mostramos el menú
                                         //capturamos la seleccion
                string opcionSeleccionada = Console.ReadLine();
                // validamos si el input es válido (en este caso podemos tmb dejar que el switch se encargue en el default.
                // lo dejo igual por las dudas si quieren usar el default del switch para otra cosa.
                String[] opcionesValidas = new String[] { "1", "2", "3", "4", "5", "6", "7","8", "X" };
                //if (ConsolaUtils.EsOpcionValida(opcionSeleccionada, opcionesValidas))
                //{
                    if (opcionSeleccionada.ToUpper() == "X")
                    {
                        continuarActivo = false;
                        continue;
                    }
                    switch (opcionSeleccionada)

                    {
                        case "1":
                            // listar
                            Program.ListarAlumnos(facultad);
                            break;
                        case "2":
                            // listar
                            Program.ListarEmpleados(facultad);
                            break;
                        case "3":
                            // alta
                            Program.AgregarAlumno(facultad);
                            break;
                        case "4":
                            // modificar
                            Program.ModificarAlumno(facultad);
                            break;
                        case "5":
                            // borrar
                            Program.EliminarAlumno(facultad);
                            break;
                        case "6":
                            // alta
                            Program.AgregarEmpleado(facultad);
                            break;
                        case "7":
                            // modificar
                            //Program.ModificarAlumno(facultad);
                            break;
                        case "8":
                            // borrar
                            //Program.EliminarEmpleado(facultad);
                            break;
                        case "9":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                //}
                //else
                //{
                //    Console.WriteLine("Opción inválida.");
                //}
                Console.WriteLine("Ingrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);
            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }
        public static void ListarAlumnos(Facultad facultad)
        {
            if(facultad.TraerAlumnos().Any())
            {
                foreach(Alumno a in facultad.TraerAlumnos())
                {
                    Console.WriteLine(a.ToString());
                }
            }
            if(facultad.TraerAlumnos()==null)
            {
                Console.WriteLine("No existen alumnos en la lista.");
            }
        }
        public static void ListarEmpleados(Facultad facultad)
        {
            if (facultad.TraerEmpleados().Any())
            {
                foreach (Empleado e in facultad.TraerEmpleados())
                {
                    Console.WriteLine(e.ToString());
                }
            }
            if (facultad.TraerEmpleados() == null)
            {
                Console.WriteLine("No existen empleados en la lista.");
            }

            

        }

        private static void AgregarAlumno(Facultad facultad)
        {
            try
            {
                int codigo = ConsolaUtils.PedirInt("Código");
                string nombre = ConsolaUtils.PedirString("Nombre");
                string apellido = ConsolaUtils.PedirString("Apellido");
                DateTime fechanacimiento = ConsolaUtils.PedirFecha("Fecha de Nacimiento");
                
                facultad.AgregarAlumno(codigo, apellido, nombre, fechanacimiento);
                Console.WriteLine("Alumno agregado");
            }
            catch(Exception ex)
            {

            }
        }
        private static void EliminarAlumno(Facultad facultad)
        {
            Console.WriteLine("Ingrese un código para eliminar alumno: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            facultad.EliminarAlumno(codigo);
            Console.WriteLine("El alumno fue eliminado");

        }

        private static void ModificarAlumno(Facultad facultad)
        {
            Console.WriteLine("Ingrese un código para modificar el alumno: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            
            facultad.EliminarAlumno(codigo);
            AgregarAlumno(facultad);
            Console.WriteLine("El alumno fue modificado");

        }
        private static void AgregarEmpleado(Facultad facultad)
        {
            try
            {
                
                string nombre = ConsolaUtils.PedirString("Nombre");
                string apellido = ConsolaUtils.PedirString("Apellido");
                DateTime fechanacimiento = ConsolaUtils.PedirFecha("Fecha de Nacimiento");
                int legajo = ConsolaUtils.PedirInt("Legajo");
                DateTime fechaingreso = ConsolaUtils.PedirFecha("Fecha de Ingreso");
                //Salario ultimosalario = ConsolaUtils.PedirSalario("Ultimo salario");
                //double bruto = ConsolaUtils.PedirDouble("Salario Bruto");
                //string codigotransferencia = ConsolaUtils.PedirString("Còdigo de transferencia");
                //double descuentos = ConsolaUtils.PedirDouble(" Descuentos");
                //DateTime fecha = ConsolaUtils.PedirFecha("Fecha de Ingreso");
                string strTipoEmpleado = ConsolaUtils.PedirString("TipoEmpleado 0)Bedel 1)Docente 2)Directivo");
                Empleado e = null;
                if (strTipoEmpleado.ToUpper() == POO.FACULTAD.BIBLIOTECA.Enum.TipoEmpleado.BEDEL.ToString())
                {
                    string apodo = ConsolaUtils.PedirString("Apodo");
                    e = new Bedel(apodo, apellido, nombre, fechanacimiento, legajo, fechaingreso);
                }

                
                if (strTipoEmpleado.ToUpper() == POO.FACULTAD.BIBLIOTECA.Enum.TipoEmpleado.DOCENTE.ToString())
                {
                    e = new Docente(apellido, nombre, fechanacimiento, legajo, fechaingreso);
                }
                if (strTipoEmpleado.ToUpper() == POO.FACULTAD.BIBLIOTECA.Enum.TipoEmpleado.DIRECTIVO.ToString())
                {
                    e = new Directivo(apellido, nombre, fechanacimiento, legajo, fechaingreso);
                }


                facultad.AgregarEmpleado(e);
                Console.WriteLine("Empleado agregado");
            }
            catch (Exception ex)
            {

            }
        }

        //public override bool Equals(Object o)
        //{
        //    if (o == null)
        //    {
        //        return false;
        //    }

        //    if (this._codigo == ((Alumno)o).Codigo)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
        //Alumno alumno = this._alumnos.Find(x => x.Equals(new Alumno(codigo)));

        //public void EliminarAlumno(int codigo)
        //{

        //    Alumno alumno = this._alumnos.Find(x => x.Equals(new Alumno(codigo)));

        //    if (alumno == null)
        //    {
        //        throw new AlumnoNoEncontradoException(codigo);
        //    }

        //    this._alumnos.Remove(alumno);

        //}
        //public void Castear()
        //{
        //    foreach(Alumno a in _lista)
        //}
        




    }
    

}
