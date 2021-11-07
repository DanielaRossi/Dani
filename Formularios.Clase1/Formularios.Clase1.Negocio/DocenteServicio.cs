using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase1.Accesodatos;
using Formularios.Clase1.Entidades;

namespace Formularios.Clase1.Negocio
{
    public class DocenteServicio
    {
        private DocenteMapper _docenteMapper;

        public DocenteServicio()
        {
            _docenteMapper = new DocenteMapper();
        }
        public List<Docente> GetDocentes()
        {
            return _docenteMapper.TraerDocentes();
        }
        public void AddDocente(Docente docente)
        {
            _docenteMapper.Agregar(docente);
        }
    }
}
