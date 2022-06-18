using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Common.Exceptions
{
    public class InvalidFieldException : Exception
    {
        public readonly string Field;
        public InvalidFieldException(string message, string field) : base(message)
        {
            Field = field;
        }
    }
}
