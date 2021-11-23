using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Entidades
{
    public class ResultadoTransaccion
    {
        public bool IsOk { get; set; }
        public string Error{ get; set; }
    public int Id{ get; set; }
    }
}
