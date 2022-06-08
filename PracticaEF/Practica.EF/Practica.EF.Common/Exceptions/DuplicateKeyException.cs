using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Common.Exceptions
{
    public class DuplicateKeyException : Exception
    {
        public readonly string Key;
        public DuplicateKeyException(string message, string key) : base(message)
        {
            Key = key;
        }

    }
}
