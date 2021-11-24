using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Entidades
{
    public class PagoModel
    {
        private List<PagoMorosos> _listapagos;
        private int _cantidad;
        private int _cantidaddìaspromedio;
        private double _interesPromedio;
        public PagoModel(List<PagoMorosos> lst)
        {
            this._listapagos = lst;
        }

        public List<PagoMorosos> Pagos
        {
            get
            {
                return _listapagos;
            }
        }
        public int Cantidad
        {
            get
            {
                if (_listapagos != null)
                    return _listapagos.Count;
                else
                    return 0;
            }
        }

        // Calcula el limite promedio de todas las tarjetas que vinieron por el constructor
        public double InteresPromedio
        {
            get
            {
                if (_listapagos != null)
                {
                    double promedio = 0;
                    double total = 0;

                    foreach (PagoMorosos p in _listapagos)
                    {
                        total += p.InteresesPunitorios;
                    }
                    promedio = total / _listapagos.Count;

                    return promedio;
                }
                else
                    return 0;
            }
        //    public double DiasPromedio
        //{
        //    get
        //    {
        //        if (_listapagos != null)
        //        {
        //            double promedio = 0;
        //            double total = 0;

        //            foreach (PagoMorosos p in _listapagos)
        //            {
        //                total += p.;
        //            }
        //            promedio = total / _listapagos.Count;

        //            return promedio;
        //        }
        //        else
        //            return 0;
        //    }
        //}
    }
    }
}
