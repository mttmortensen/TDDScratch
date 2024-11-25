using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDScratch
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int CalculateRectangleArea(int b, int h)
        {
            return b * h;
        }

        public double FahrenheitToCelsius(int f)
        {

            double formula = (f - 32) * 5 / 9;

            return Math.Floor(formula);
        }

        public bool IsEven(int num)
        {
            if (num % 2 == 1)
            {
                return false;
            }

            return true;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
