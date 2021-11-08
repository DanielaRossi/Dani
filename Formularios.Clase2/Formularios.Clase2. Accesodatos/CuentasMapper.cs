using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase2.Entidades;

namespace Formularios.Clase2.Accesodatos
{
    public class CuentasMapper
    {
        private List<Cuentas> _cuentas;

        public CuentasMapper()
        {
            _cuentas = new List<Cuentas>();
            _cuentas.Add(new Cuentas(1, 1, "Caja de ahorro", Convert.ToDouble(300), Convert.ToDateTime("21-02-2000"),Convert.ToDateTime( "08-11-2020"), true, 1));
            _cuentas.Add(new Cuentas(2, 2, "Caja de ahorro en dolares", Convert.ToDouble(3000), Convert.ToDateTime("21-02-2002"), Convert.ToDateTime("08-09-2020"), false, 2));
            _cuentas.Add(new Cuentas(3, 3, "Caja de ahorro", Convert.ToDouble(100), Convert.ToDateTime("21-02-2020"), Convert.ToDateTime("08-10-2020"), true, 3));
        }
        public List<Cuentas> TraerCuentas()
        {
            return _cuentas;
        }
        public void Agregar(Cuentas cuentas)
        {
            _cuentas.Add(cuentas);
        }



    }
}
