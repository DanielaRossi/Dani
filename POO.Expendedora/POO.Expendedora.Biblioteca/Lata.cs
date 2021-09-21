﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Expendedora.Biblioteca
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        public string Codigo
        {
            get
            {
                return _codigo;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public string Sabor
        {
            get
            {
                return _sabor;
            }
        }
        public double Precio
        {
            get
            {
                return _precio;
            }
        }
        public double Volumen
        {
            get
            {
                return _volumen;
            }
        }
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
        }
        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            codigo = _codigo;
            nombre = _nombre;
            sabor = _sabor;
            precio = _precio;
            volumen = _volumen;
            cantidad = _cantidad;
        }
        public double GetPrecioPorLitro()
        {
            return 20;
        }
        public override string ToString()
        {
            return " Es una lata.";
        }


    }
}