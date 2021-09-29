using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public class Presentismo
    {
        // iniciar Presentismo con los siguientes datos
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
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        private bool AsistenciaRegistrada(string fecha)
        {
            return false;
        }
        private int GetCantidadAlumnosRegulares()
        {
            return 0;
        }
        public Preceptor GetPreceptorActivo()
        {
            return;
        }
        public List<Alumno> GetListaAlumnos(string)
        {
            return;
        }
        public void AgregarAsistencia(List<Asistencia>, string)
        {

        }
        public List<Asistencia> GetAsistenciasPorFecha(string)
        {
            return;
        }

    }
    
