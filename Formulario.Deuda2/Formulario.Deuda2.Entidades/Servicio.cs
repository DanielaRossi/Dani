using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Entidades
{
    public class Servicio
    {
        private int _id;
        private double _punitoiroDiario;
        private string _nombre;

        public Servicio(int id, string nombre, double punitoiroDiario)
        {
            _id = id;
            _punitoiroDiario = punitoiroDiario;
            _nombre = nombre;
        }
        public Servicio()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public double PunitoiroDiario { get => _punitoiroDiario; set => _punitoiroDiario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public override string ToString()
        {
            return string.Format("{0}){1}", this._id, this._nombre);
        }



    }
}
