using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Datos;
using TarjetaCredito.Entidades;
using TarjetaCredito.Entidades.Enum;

namespace TarjetaCredito.Negocio
{
    public class TarjetaNegocio
    {
        private TarjetaMapper _tarjetaMapper;
        //private ClienteMapper _clienteMapper;
        

        private List<Tarjeta> _tarjetas;
        //private List<Cliente> listaclientes;

        public TarjetaNegocio()
        {
            _tarjetaMapper = new TarjetaMapper();
            //_clienteMapper = new ClienteMapper();
            _tarjetas = new List<Tarjeta>();
            //listaclientes = new List<Cliente>();
        }
        public List<Tarjeta> TraerSinCliente()
        {
            _tarjetas = _tarjetaMapper.TraerTodos();
            return _tarjetas;
        }
        //public List<Tarjeta> TraerConCliente()
        //{
        //    _tarjetas = _tarjetaMapper.TraerTodos();
        //    listaclientes = _clienteMapper.TraerTodos();
        //    foreach (var cliente in listaclientes)
        //    {
        //        foreach (var tarjeta in _tarjetas)
        //        {
        //            if (tarjeta.IdCliente == cliente.id) 
        //            {
        //                cliente.Tarjeta = tarjeta;
        //            }
        //        }
        //    }
        //    return listaclientes;
        //}
        public void Alta(TipoTarjetaEnum tipo, PeriodoEnum periodo, Cliente cliente, string plastico, double limiteSolicitado)
        {
            // validamos que el cliente tenga una cuenta
            //if (cliente.Cuenta == null)
            //{
            //    throw new ClienteSinCuentaException();
            //}

            // validacion de negocio limite del saldo correspondiente con la cuenta
            //if (cliente.Cuenta.Saldo * 18 > limiteSolicitado)
            //{
            //    throw new ClienteSinLimiteException();
            //}

            Tarjeta tarjeta = new Tarjeta((int)tipo, (int)periodo,  limiteSolicitado, plastico, cliente.id);

            ResultadoTransaccion result = _tarjetaMapper.Insertar(tarjeta);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }

        }
        public string CalcularNroPlastico(Cliente cliente, TipoTarjetaEnum tipo, PeriodoEnum periodo)
        {

            string plasticoBase = "43001000" + DateTime.Now.Millisecond.ToString(); // base para concatenar

            string resultado = plasticoBase + ((int)tipo).ToString() + ((int)periodo) + cliente.id.ToString();

            if (tipo == TipoTarjetaEnum.AMEX)
                resultado = resultado.Substring(1, 15);

            return resultado;
        }
    }
}
