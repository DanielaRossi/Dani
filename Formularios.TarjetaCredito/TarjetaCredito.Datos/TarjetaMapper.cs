using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Entidades;

namespace TarjetaCredito.Datos
{
    public class TarjetaMapper
    {
        public List<Tarjeta> TraerTodos()
        {
            string json2 = WebHelper.Get("tarjeta/880671");
            List<Tarjeta> resultado = MapList(json2);
            return resultado;
        }
        private List<Tarjeta> MapList(string json2)
        {
            List<Tarjeta> lst = JsonConvert.DeserializeObject<List<Tarjeta>> (json2);
            return lst;
        }
        public ResultadoTransaccion Insertar(Tarjeta tarjeta)
        {
            NameValueCollection obj = ReverseMap(tarjeta);
            string json = WebHelper.Post("tarjeta", obj);
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Tarjeta tarjeta)
        {
            NameValueCollection nv = new NameValueCollection();
            nv.Add("tipo", tarjeta.Tipo.ToString());
            nv.Add("periodoVencimiento", tarjeta.PeriodoVencimiento.ToString());
            nv.Add("limiteCompra", tarjeta.LimiteCompra.ToString("0.00"));
            nv.Add("nroPlastico", tarjeta.NroPlastico);
            nv.Add("usuario", "880671");
            nv.Add("idCliente", tarjeta.IdCliente.ToString());

            return nv;
        }
    }
}
