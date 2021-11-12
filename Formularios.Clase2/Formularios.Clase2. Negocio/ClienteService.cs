using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase2.Accesodatos;
using Formularios.Clase2.Entidades;

namespace Formularios.Clase2.Negocio
{
    public class ClienteService
    {
        private ClienteMapperHTTP _clienteMapper;
        public ClienteService()
        {
            _clienteMapper = new ClienteMapperHTTP();

        }
        public List<Clientes> GetCliente()
        {
            return _clienteMapper.TraerCliente();
        }
        public void AddCliente(Clientes cliente)
        {
            
             TransactionResult resultado = _clienteMapper.Agregar(cliente);

            if (resultado.IsOk == false)
                throw new Exception("No se pudo insertar el cliente. Motivo " + resultado.Error);

        }
    }
}
