﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_transportes.Clases
{
    public class Taxi : TransportePublico
    {
        public Taxi(int _pasajeros) : base(_pasajeros)
        {
        }

        public override string Avanzar()
        {
            if(_isDetenido)
                return "El Taxi arrancó";
            else
                return "El Taxi ya se encuentra en movimiento";
        }

        public override string Detenerse()
        {
            if(!_isDetenido)
                return "El Taxi arrancó";
            else
                return "El Taxi ya se encuentra en detenido";
        }
    }
}
