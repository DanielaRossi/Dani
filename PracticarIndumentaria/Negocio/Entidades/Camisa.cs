using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Camisa: Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        public Camisa(bool tieneEstampado, string tipoManga,TipoIndumentaria tipo, int codigo,int stock,string talle,double precio):base(tipo,codigo,stock, talle, precio)
        {
            _tieneEstampado = tieneEstampado;
            _tipoManga = tipoManga;
        }

        public bool TieneEstampado { get => _tieneEstampado; set => _tieneEstampado = value; }
        public string TipoManga { get => _tipoManga; set => _tipoManga = value; }
        public override string GetDetalle()
        {
            return $"Camisa: {this.Codigo})-Estampado:{this._tieneEstampado}-Tipo manga{this._tieneEstampado}";
        }
    }
}
