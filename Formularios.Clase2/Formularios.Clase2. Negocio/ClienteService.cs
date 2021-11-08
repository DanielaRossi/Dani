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
        private ClienteMapper _clienteMapper;
        public ClienteService()
        {
            _clienteMapper = new ClienteMapper();

        }
        public List<Cliente> GetCliente()
        {
            return _clienteMapper.TraerCliente();
        }
        public void AddCliente(Cliente cliente)
        {
            _clienteMapper.Agregar(cliente);
        }
    }
}
