using Formulario.Deuda2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.AccesoDatos
{
    public class PagoMapper
    {
        public List<PagoMorosos> TraerTodos()
        {
            string json2 = WebHelper.Get("PagoMorosos/880671");
            List<PagoMorosos> resultado = MapList(json2);
                return resultado;
        }
        private List<PagoMorosos> MapList(string json2)
        {
            //List<PagoMorosos> lst = JsonConvert.DeserializeObject< List < PagoMorosos >> (json2);
            //return lst;
            var set = new JsonSerializerSettings();
            set.Culture = new System.Globalization.CultureInfo("es-AR");
            List<PagoMorosos> lst = JsonConvert.DeserializeObject<List<PagoMorosos>>(json2, set);
            return lst;
        }

        public TransactionResult Insertar(PagoMorosos pagomorosos)
        {
            NameValueCollection obj = ReverseMap(pagomorosos);
            string json = WebHelper.Post("PagoMorosos", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(PagoMorosos pagomorosos)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idServicio", pagomorosos.IdServicio.ToString());
            n.Add("idCliente", "0");
            n.Add("fechaVencimiento", pagomorosos.FechaVencimiento.ToString("yyyy-MM-dd"));
            n.Add("fechaPago",pagomorosos.FechaPago.ToString("yyyy-MM-dd"));
            n.Add("importeAdeudado", pagomorosos.ImporteAdeudado.ToString("0.00"));
            n.Add("interesPunitorio", pagomorosos.InteresesPunitorios.ToString("0.00"));
            n.Add("usuario", "880671");
            n.Add("id", pagomorosos.Id.ToString());

            return n;
        }
    }
}
