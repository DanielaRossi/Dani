using Formulario.Deuda2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Negocio
{
    public static class ServicioHelper
    {
        private static List<Servicio> _servicios;

        static ServicioHelper()
        {
            _servicios = new List<Servicio>();
            Servicio ser0 = new Servicio(0, "Seleccione", 0);
            Servicio ser1 = new Servicio(1, "Edenor", 8.45);
            Servicio ser2 = new Servicio(2, "Expensas",5.20);
            Servicio ser3 = new Servicio(3, "Telecom",2.21);

            _servicios.Add(ser0);
            _servicios.Add(ser1);
            _servicios.Add(ser2);
            _servicios.Add(ser3);
        }

        public static List<Servicio> GetServicos()
        {
            return _servicios;
        }


        public static Servicio GetServicioPorId(int id)
        {
            Servicio resultado = null;

            foreach (Servicio s in _servicios)
            {
                if (s.Id == id)
                {
                    resultado = s;
                }
            }

            return resultado;
        }
    }
}
