using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formularios.Clase2.Entidades;
using Newtonsoft.Json;


namespace Formularios.Clase2.Accesodatos
{
    public class ClienteMapperHTTP
    {
        private List<Clientes> _clientes;
        public ClienteMapperHTTP()
        {
           
        }
        //public List<Clientes> TraerCliente()
        //{
        //    string json2 = WebHelper.Get("cliente/NRO-REGISTRO-ALUMNO");

        //    _clientes = MapList(json2);
        //    return _clientes;
        //}
        //private List<Clientes> MapList(string json)
        //{
        //    List<Clientes> lst = JsonConvert.DeserializeObject<List<Clientes>>(json);
        //    return lst;
        //}
        public List<Clientes> TraerCliente()
        {
            string json2 = WebHelper.Get("cliente");

            _clientes = JsonConvert.DeserializeObject<List<Clientes>>(json2);
            return _clientes;
        }


        //public void Agregar(Clientes cliente)
        //{
        //    _clientes.Add(cliente);
        //}
        public TransactionResult Agregar(Clientes cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            //_docentes.Add(docente);

            return lst;

        }
        private NameValueCollection ReverseMap(Clientes cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("dni", Convert.ToString(cliente.Cuit));
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido);
            n.Add("direccion", cliente.Dirección);
            n.Add("email", cliente.Email);
            n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString());
            n.Add("fechaAlta", DateTime.Now.ToString());
            n.Add("activo", "true");
            n.Add("usuario", "880671");
            n.Add("id", cliente.Id.ToString());
            return n;
        }
    }
}
