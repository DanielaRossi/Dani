using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRESENTISMO.BIBLIOTECA
{
    public class Alumnoregular: Alumno
    {
        private string _email;
        public string Email { get => _email; set => _email = value; }

        public Alumnoregular(int, string, string, string)
        {

        }
    }
}
