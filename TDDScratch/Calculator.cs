﻿using System;
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

        public double FahrenheitToCelsius(double f)
        {
            throw new NotImplementedException();
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
