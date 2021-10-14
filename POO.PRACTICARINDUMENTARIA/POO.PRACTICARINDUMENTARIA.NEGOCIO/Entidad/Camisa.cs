using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public class Camisa: Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        public bool TieneEstampado { get => _tieneEstampado; set => _tieneEstampado = value; }
        public string TipoManga { get => _tipoManga; set => _tipoManga = value; }

        public string GetDetalle()
        {
            return string.Format("{ 0}-{1}", _tieneEstampado, _tipoManga);
        }
        public Camisa(int codigo, int stock, string talle, double precio, TipoIndumentaria t, bool estampado, string manga): base(codigo,stock, talle, precio, t)
        {
            this._tieneEstampado = estampado;
            this._tipoManga = manga;
        }
    }
}
