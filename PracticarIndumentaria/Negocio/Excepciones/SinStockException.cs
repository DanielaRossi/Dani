﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Excepciones
{
    public class SinStockException : Exception
    {
        public SinStockException(string message) : base(message)
        {
        }
    }
}
