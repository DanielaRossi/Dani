using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Pantalon: Indumentaria
    {
        private string _material;
        private bool _tieneBolsillos;

        public Pantalon(string material, bool tienebolsillos,TipoIndumentaria tipo, int codigo, int stock, string talle, double precio) : base(tipo, codigo, stock, talle, precio)
        {
            _material = material;
            _tieneBolsillos = tienebolsillos;
        }

        public string Material { get => _material; set => _material = value; }
        public bool TieneBolsillos { get => _tieneBolsillos; set => _tieneBolsillos = value; }

        public override string GetDetalle()
        {
            return $"Pantalon: {this.Codigo})-Material{this._material}";
        }
    }
}
