using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.SegundaClase.Biblioteca
{
    public class Cliente
    {
        //atributos de clase
        private int _numeroDocumento;
        private string _nombre;
        private string _apellido;
        private DateTime _edad;
        private DateTime _fechaNacimiento;

        //propiedades
        public int NumeroDocumento
        {
            get
            {
                return _numeroDocumento;
            }
            set
            {
                _numeroDocumento = value;
            }
        }
        public int GetNumeroDocumento()
        {
            return _numeroDocumento;
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }
        public bool EsMayor
        {
            get
            {
                if ((DateTime.Now.Year - _fechaNacimiento.Year) > 18)
                    return true;
                else
                    return false;
            }
        }
    }
}
