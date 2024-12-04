
namespace TDDScratch
{
    public class Loops_120324
    {
        public bool IsPalindrome(string wordToCheck)
        {
            string reversedWord = "";

            // I think I need to reverse the string first
            for (int i = wordToCheck.Length - 1; i >= 0; i--) 
            {
                reversedWord += wordToCheck[i];
            }

            return wordToCheck == reversedWord;
        }
    }
}
