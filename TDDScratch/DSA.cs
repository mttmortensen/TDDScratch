using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDScratch
{
    public class DSA
    {
        public bool IsPrime(int v)
        {
            throw new NotImplementedException();
        }

        public string ReverseString(string stringToReverse)
        {
            string reversedString = "";

            for (int i = stringToReverse.Length - 1; i >= 0; i--) 
            {
                reversedString += stringToReverse[i];    
            }

            return reversedString;
        }
    }
}
