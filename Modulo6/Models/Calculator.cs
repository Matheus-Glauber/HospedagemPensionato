using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo6.Models
{
    class Calculator
    {
        public static double Sum(params int[] numbers)
        {
            double resul = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                resul += numbers[i];
            }

            return resul;
        }

        public static void Dobrar(int valorEntrada, out int valorDobrado)
        {
            valorDobrado = valorEntrada * 2;
        }
        public static void Triplicar(ref int valor)
        {
            valor = valor * 3;
        }
    }
}
