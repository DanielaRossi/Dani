using Formulario.Deuda2.AccesoDatos;
using Formulario.Deuda2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Negocio
{
    public class PagoNegocio
    {
        private PagoMapper _pagoMapper;
        private List<PagoMorosos> listapagos;

        public PagoNegocio()
        {
            _pagoMapper = new PagoMapper();
            listapagos = new List<PagoMorosos>();
        }

        public List<PagoMorosos> Traer()
        {
            listapagos= _pagoMapper.TraerTodos();
            foreach(PagoMorosos p in listapagos)
            {
                p.Servicio = ServicioHelper.GetServicioPorId(p.IdServicio);
               
            }
            return listapagos;
        }

        public TransactionResult Insertar(int idservicio, int idcliente, DateTime fechav, DateTime fechapago, double importeadeudado, double interespunitorio)
        {
            PagoMorosos pagomorosos = new PagoMorosos();
            pagomorosos.IdServicio = idservicio;
            pagomorosos.IdCliente = idcliente;
            pagomorosos.FechaVencimiento = fechav;
            pagomorosos.FechaPago = fechapago;
            pagomorosos.ImporteAdeudado = importeadeudado;
            
            //pagomorosos.InteresesPunitorios = interespunitorio;
            TransactionResult result = _pagoMapper.Insertar(pagomorosos);
            return result;

        }
        
        

        }
    }

