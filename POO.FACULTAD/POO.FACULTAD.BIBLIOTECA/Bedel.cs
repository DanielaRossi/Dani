﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.FACULTAD.BIBLIOTECA
{
    public class Bedel : Empleado
    {
        protected string _apodo;
        public string Apodo { get => _apodo; }

        public virtual string GetNombreCompleto()
        {
            return "Nombre completo del bedel.";
        }
    }
}
