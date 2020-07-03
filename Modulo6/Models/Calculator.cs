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
    }
}
