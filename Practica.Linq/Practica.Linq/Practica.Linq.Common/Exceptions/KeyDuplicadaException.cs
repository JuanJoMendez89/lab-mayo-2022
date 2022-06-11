using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Common.Exceptions
{
    public class KeyDuplicadaException : Exception
    {
        public string Key { get; }
        public KeyDuplicadaException(string mensaje, string key) : base(mensaje)
        {
            Key = key;
        }
    }
}
