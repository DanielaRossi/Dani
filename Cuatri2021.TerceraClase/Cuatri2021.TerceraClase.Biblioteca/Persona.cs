using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuatri2021.TerceraClase.Biblioteca
{
    public class Persona
    {
        //atributos
        private string _nombre;
        private int _modificacionNombre;
        private int _porcentajeCansancio;
        //propiedad
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if(value!=string.Empty)
                    {
                    _nombre = value;
                    _modificacionNombre++;
                }
                
            }
        }
        public int PorcentajeEstadoFisico
        {
            get
            {
                return _porcentajeCansancio;
            }
        }
        public void Correr()
        {
            _porcentajeCansancio -= 10;
        }
    }
}
