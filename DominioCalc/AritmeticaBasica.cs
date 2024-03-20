using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioCalc
{
    public class AritmeticaBasica
    {
        public AritmeticaBasica()
        {

        }
        public int Sumar(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Restar(int num1, int num2)
        {
            return (num1 - num2);
        }
        public int Multiplicar(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int Dividir(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Error al dividir por cero.");
            }
            return result;
        }

    }
}
