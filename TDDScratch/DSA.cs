namespace TDDScratch
{
    public class DSA
    {
        public int CountWords(string words)
        {

            int count = 0;

            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i] == ' ')
                {
                    count++;
                }
            }

            // Handle the last word since there is no space 

            if (words.Length - 1 != ' ')
            {
                count++;
            }

            return count;
        }

        public bool IsPrime(int num)
        {
            // Handling if the num is equal or greater than 1
            if (num <= 1 ) return false;

            // Handle the specifc edge case for 2 
            if (num == 2) return true;

            // Loop from 2 to sqr root of the number to check divisibility
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                // If number is divisible by 1, it's not prime
                if (num % i == 0) return false;
            }

            // If no divisors found, then the number is prime
            return true;
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
