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
        private Dirección _domicilio;
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
        public bool EstaCansado()
        {
            if(_porcentajeCansancio<70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Multiplicador(int cantidad)
        {
            return _porcentajeCansancio * cantidad;
        }
        public void Correr(bool obstaculo)
        {
            if(obstaculo)
            {
                _porcentajeCansancio -= 20;
            }
            else{
                _porcentajeCansancio -= 10;
            }
        }
        public Persona()
        {
            _porcentajeCansancio = 100;
            _nombre = "Sin nombre";
            Dirección _domicilio = new Dirección("Cuenca", 2000);
        }
        public Persona(string nombre, string calle, int numero)
        {
            
            _nombre = nombre;
            _domicilio = new Dirección(calle, numero);
        }
        public string Domicilio
        {
            get
            {
                return _domicilio.DireccionCompleta;
            }
        }
    }
}
