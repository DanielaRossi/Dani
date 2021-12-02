using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cliente
    {
        private int _codigo;
        private string _apellido;
        private string _nombre;

        public Cliente(int codigo, string apellido, string nombre)
        {
            Codigo = codigo;
            Apellido = apellido;
            Nombre = nombre;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
