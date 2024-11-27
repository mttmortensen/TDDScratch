


namespace TDDScratch
{
    public class Loops_112724
    {
        public int CountVowels(string word)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            int vowelCount = 0;

            for (int i = 0; i < word.Length - 1 ; i++) 
            {
                for (int j = 0; j < vowels.Length - 1; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
            }

            return vowelCount;
        }

        public int SumOfNumbers(int num)
        {
            int total = 0;

            for (int i = 0; i <= num; i++) 
            {
                total += i;
            }
            return total;
        }
    
        public int[] GenerateMultiplicationTable(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
