using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.REPASOPRESENTISMO.NEGOCIO.ENTIDADES
{
    public class Alumnoregular
    {
        private string _email;
        public string Email { get => _email; set => _email = value; }

        public Alumnoregular(int registro, string nombre, string apellido, string email): base(nombre , apellido)
        {
            this._email = email;
        }
    }
}
