using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Deuda2.Entidades
{
    public class TransactionResult
    {
        private bool _isOk;
        private string _error;
        private int _id;

        public bool IsOk { get => _isOk; set => _isOk = value; }
        public string Error { get => _error; set => _error = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
