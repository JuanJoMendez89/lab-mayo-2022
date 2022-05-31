using LogicaLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLayer
{
    public class Logic
    {
        public Logic()
        {

        }

        public static void DispararExcepcion() {
            throw new NotImplementedException();
        }

        public static void DispararExcepcionPersonalizada() {
            throw new ExcesoDeFachaException();
        }

    }
}
