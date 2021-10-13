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
        public Preceptor GetPreceptoractivo()
        {
            foreach(Preceptor preceptor in _preceptores)
            {
                if(_preceptores!=null)
                {
                    return preceptor;
                }
            }
            return null;
        }
        //public List<Alumno> GetListaAlumno(string fecha)
        //{
        //    foreach (Alumno a in _alumnos)
        //    {
        //        if (a.)
        //    }
        //}
        public List<Alumno> GetListaAlumno()
        {
            if(_alumnos.Count == 0)
            {
                return null;
            }
            else
            {
                return _alumnos;
            }
        }
        public void AgregarAsistencia(List<Asistencia>_asistencias, string fecha)
        {

        }
        public void AgregarAsistencia(string fecha, DateTime fechareal, Preceptor preceptor, Alumno alumno, bool presente)
        {
            Asistencia a = new Asistencia(fecha, fechareal, preceptor, alumno, presente);
            _asistencias.Add(a);
        }
        //public List<Asistencia> GetAsistenciasPorFecha(string)
        //{
        //    return
        //}
    }
    }
