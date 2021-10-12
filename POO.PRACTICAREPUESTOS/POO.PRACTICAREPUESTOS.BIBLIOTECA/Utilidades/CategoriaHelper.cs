using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.PRACTICAREPUESTOS.BIBLIOTECA.Entidades;

namespace POO.PRACTICAREPUESTOS.BIBLIOTECA.Utilidades
{
    public static class CategoriaHelper
    {
        private static List<Categoria> _lista;

        static CategoriaHelper()
        {
            _lista = new List<Categoria>();
            Categoria cat1 = new Categoria(1, "Guardianes");
            Categoria cat2 = new Categoria(2, "Peluches");
            Categoria cat3 = new Categoria(3, "Glotones");

            _lista.Add(cat1);
            _lista.Add(cat2);
            _lista.Add(cat3);
        }

        public static List<Categoria> GetCategorias()
        {
            return _lista;
        }


        public static Categoria GetCategoriasPorCodigo(int cod)
        {
            Categoria resultado = null;

            foreach (Categoria c in _lista)
            {
                if (c.Codigo == cod)
                {
                    resultado = c;
                }
            }

            return resultado;
        }
    }
}
