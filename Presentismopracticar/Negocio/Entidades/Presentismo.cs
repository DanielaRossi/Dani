using Negocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Presentismo
    {
        List<Preceptor> _preceptores;
        List<Alumno> _alumnos;
        List<Asistencia> _asistencias;
        List<string> _fechas;

        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }
        

        private bool AsistenciaRegistrada(string fecha)
        {
            return true;
        }
        private int GetCantidadAlumnosRegulares()
        {
            int total = 0;
            if (_alumnos.Count == 0)
            {
                throw new Exception("No hay alumnos.");
            }
            else
            {
                foreach (Alumno a in _alumnos)
                {
                    if (a is AlumnoRegular)
                    {
                        total += 1;
                    }
                }
                return total;
            }
            

            
        }
        public Preceptor GetPreceptorActivo()
        {
            Preceptor preceptoractivo = null;
            foreach(Preceptor p in _preceptores)
            {
                if (p.Legajo == 5)
                {
                    preceptoractivo = p;
                }
            }
            if (preceptoractivo == null)
            {
                throw new Exception("No se encontrò el preceptor.");
            }
            return preceptoractivo;
        }
        public List<Alumno>GetListaAlumnos(string fecha)
        {
            //List<Alumno> _alumnos = new List<Alumno>();
            //foreach( Asistencia a in _asistencias)
            //{
            //    if(a.FechaReferencia== fecha)
            //    {
            //        _alumnos.Add(a.Alumno);
            //    }
            //}
            //return _alumnos;
            foreach(string f in _fechas)
            {
                if(fecha == f)
                {
                    throw new AsistenciaExistenteEseDiaException();
                }
            }
            return _alumnos;
        }
        //public List<Alumno> ListaAlumnosRegulares()
        //{
        //    List<Alumno> lst = null;
        //    foreach (Alumno a in _alumnos)
        //    {
        //        if (a is AlumnoRegular)
        //        {
        //            lst.Add(a);
        //        }
        //    }
        //    return lst;
        //}
        public void AgregarAsistencia(List<Asistencia>lst, string fecha)
        {
            if (lst.Count != GetCantidadAlumnosRegulares())
            {
                throw new AsistenciaInconsistenteException();
            }
            foreach(Asistencia a in _asistencias)
            {
                if(a.FechaReferencia== fecha)
                {
                    throw new AsistenciaExistenteEseDiaException();
                }
            }
            _fechas.Add(fecha);
            _asistencias.AddRange(lst);

        }
        //public void CargarAsistencia (Asistencia asistencia)
        //{
        //    _asistencias.Add(asistencia);
        //}
        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            List<Asistencia> lst = new List<Asistencia>();
            foreach (Asistencia a in _asistencias)
            {
                if (a.FechaReferencia == fecha)
                {
                   lst.Add(a);
                }
                if(lst==null)
                {
                    throw new AsistenciaExistenteEseDiaException();
                }
                
            }
            return lst;
        }
    }
}
