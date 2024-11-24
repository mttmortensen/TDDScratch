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

        public bool IsEven(int num)
        {
            if (num == 1 % 2)
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
