using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.REPASOPRESENTISMO.NEGOCIO.EXCEPCIONES;

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

        private bool AsistenciaRegistrada(string fecha)
        {
            foreach(string f in _fechas)
            {
                if(f == fecha)
                {
                    return true;
                }
            }
            return false;
        }
        private int GetCantidadAlumnosRegulares()
        {
            int Cantidad = 0;
            foreach(Alumno a in _alumnos)
            {
                if(a is Alumnoregular)
                {
                    Cantidad++;
                }
            }
            return Cantidad;
        }
        public Preceptor GetPreceptoractivo()
        {
            if (_preceptores.Any())
            {
                return _preceptores.Last();
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
            if(this.GetCantidadAlumnosRegulares() == _asistencias.Count)
            {
                if(!this.AsistenciaRegistrada(fecha))
                {
                    foreach(Asistencia a in _asistencias)
                    {
                        _asistencias.Add(a);
                    }
                }
                else
                {
                    throw new AsistenciaExistenteEseDiaExcepcion();
                }
            }
            else
            {
                throw new AsistenciaInconsistenteExcepcion();
            }
        }
        public void AgregarAsistencia(string fecha, DateTime fechareal, Preceptor preceptor, Alumno alumno, bool presente)
        {
            Asistencia a = new Asistencia(fecha, fechareal, preceptor, alumno, presente);
            _asistencias.Add(a);
        }
        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            List<Asistencia> Lista = new List<Asistencia>();
            if (_asistencias.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (Asistencia a in _asistencias)
                {
                    if (a.FechaReferencia == fecha)
                    {
                        Lista.Add(a);
                    }
                }
            }
            return Lista;
        }
    }
}
