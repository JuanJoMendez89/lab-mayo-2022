using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLayer.Exceptions
{
    public class ExcesoDeFachaException : Exception
    {
        public ExcesoDeFachaException(): base("Indice de facha Its over 9000")
        {
        }
    }
}
