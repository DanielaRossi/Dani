using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.PRACTICARINDUMENTARIA.NEGOCIO.Entidad
{
    public class TipoIndumentaria
    {
        private string _orden;
        private double _porcentajeAlgodon;
        public string Orden { get => _orden; set => _orden = value; }

        public double PorcentajeAlgodon { get => _porcentajeAlgodon; set => _porcentajeAlgodon = value; }

        public TipoIndumentaria(string orden, double porcentaje)
        {
            this._orden = orden;
            this._porcentajeAlgodon = porcentaje;
        }
    }
}
