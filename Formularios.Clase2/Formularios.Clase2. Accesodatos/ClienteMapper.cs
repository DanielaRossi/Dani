using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase2.Entidades;

namespace Formularios.Clase2.Accesodatos
{
    public class ClienteMapper
    {
        private List<Clientes> _clientes;
        public ClienteMapper()
        {
            _clientes = new List<Clientes>();
            _clientes.Add(new Clientes(1, true, "Agustina", "Rossi", "Pedro Moran 3100", "1111111", "aaa@yahoo.com",Convert.ToDateTime("18-02-1997"), Convert.ToInt64(27401294409)));
            _clientes.Add(new Clientes(2, true, "Daniela", "Rossi", "Pedro Moran 3100", "1111111", "aaa@yahoo.com", Convert.ToDateTime("21 - 07- 1995"), Convert.ToInt64(27392079209)));
            _clientes.Add(new Clientes(3, false, "Patricia", "Lopez", "Pedro Moran 3100", "1111111", "aaa@yahoo.com", Convert.ToDateTime("03 - 12 - 1997"), Convert.ToInt64(27201294409)));
        }
        public List<Clientes> TraerCliente()
        {
            return _clientes;
        }
        public void Agregar(Clientes cliente)
        {
            _clientes.Add(cliente);
        }
    }
}
