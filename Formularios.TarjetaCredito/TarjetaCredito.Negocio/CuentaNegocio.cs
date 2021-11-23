using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Datos;
using TarjetaCredito.Entidades;

namespace TarjetaCredito.Negocio
{
    public class CuentaNegocio
    {

        private CuentaMapper _cuentaMapper;

        public CuentaNegocio()
        {
            _cuentaMapper = new CuentaMapper();
        }

        public Cuenta TraerPorCliente(int idCliente)
        {
            return _cuentaMapper.Traer(idCliente);
        }

        public Cuenta Alta(Cuenta cuenta)
        {
            ResultadoTransaccion result = _cuentaMapper.Alta(cuenta);

            if (result.IsOk)
            {
                Cuenta cuentaNueva = _cuentaMapper.Traer(cuenta.idCliente);
                return cuentaNueva;
            }
            else
                return null;

        }

        public Cuenta Update(Cuenta cuenta)
        {
            ResultadoTransaccion result = _cuentaMapper.Actualizar(cuenta);

            if (result.IsOk)
            {
                //ir a buscar la cuenta nuevamente
                return _cuentaMapper.Traer(cuenta.idCliente);
            }
            else
            {
                return cuenta;
            }


        }
    }
}
