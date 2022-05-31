using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLayer.ExtensionMethods
{
    public static class DecimalExtensions
    {
        public static decimal DividirPorCero(this decimal valor) {
            try
            {
                decimal res = valor / 0;

                return res;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public static decimal Dividir(this decimal valor1, decimal valor2) {
            try
            {
                decimal resultado = valor1 / valor2;

                return resultado;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
