using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICAREPUESTOS.BIBLIOTECA.Entidades
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        //public string GetCategoria()
        //{
        //    return _codigo +_nombre;
        //}
        public Categoria(int codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
        }

    }
}
