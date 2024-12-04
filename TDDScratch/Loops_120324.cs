
namespace TDDScratch
{
    public class Loops_120324
    {
        public bool IsPalindrome(string wordToCheck)
        {
            bool isItAPalindrome = false;

            string reversedWord = "";

            // I think I need to reverse the string first
            for (int i = wordToCheck.Length - 1; i >= 0; i++) 
            {
                reversedWord += reversedWord[i];
            }

            for (int i = 0; i < wordToCheck.Length; i++) 
            {
                if (reversedWord[i] == wordToCheck[i])
                {
                    isItAPalindrome = true;
                }
            }

            return isItAPalindrome;
        }
    }
}
