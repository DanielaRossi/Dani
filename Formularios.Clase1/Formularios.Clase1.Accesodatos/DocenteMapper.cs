using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase1.Entidades;

namespace Formularios.Clase1.Accesodatos
{
    public class DocenteMapper
    {
        private List<Docente> _docentes;

        public DocenteMapper()
        {
            _docentes = new List<Docente>();
            _docentes.Add(new Docente(1, "Rodolfo", "Zavala", new TipoDocumento(1, "Soltero")));
            _docentes.Add(new Docente(2, "Suyai", "Pecoraro", new TipoDocumento(1, "Soltero")));
            _docentes.Add(new Docente(3, "Blanco", "Marcelo", new TipoDocumento(1, "Soltero")));
        }
        public List<Docente> TraerDocentes()
        {
            return _docentes;
        }
        public void Agregar(Docente docente)
        {
            _docentes.Add(docente);
        }


    }
}
