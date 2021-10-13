using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public class Presentismo
    {

        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();
            _alumnos.Add(new Alumnoregular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new Alumnoregular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new Alumnooyente(320, "Ramona", "Vals"));
            _alumnos.Add(new Alumnooyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }

            //private bool AsistenciaRegistrada(string fecha)
            //{
            //    return 
            //}
            //private int GetCantidadAlumnosRegulares()
            //{
            //    return
            //}
            //public Preceptor GetPreceptoractivo()
            //{
            //    return
            //}
            //public List<Alumno> GetListaAlumno(string)
            //{
            //    return
            //}
            //public void AgregarAsistencia(List<Asistencia>, string)
            //{

            //}
            //public List<Asistencia> GetAsistenciasPorFecha(string)
            //{
            //    return
            //}
        }
    }
