using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase2.Accesodatos;
using Formularios.Clase2.Entidades;

namespace Formularios.Clase2.Negocio
{
    public class CuentasService
    {
        private CuentasMapper _cuentasMapper;
        public CuentasService()
        {
            _cuentasMapper = new CuentasMapper();

        }
        public List<Cuentas> GetCliente()
        {
            return _cuentasMapper.TraerCuentas();
        }
        public void AddCuentas(Cuentas cuentas)
        {
            _cuentasMapper.Agregar(cuentas);
        }

    }
}
