using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_transportes.Clases
{
    public abstract class TransportePublico
    {
        protected int _pasajeros;

        public TransportePublico(int _pasajeros)
        {
            this._pasajeros = _pasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        public int pasajeros
        {
            get {
                return _pasajeros;
            }
        }

    }
}
