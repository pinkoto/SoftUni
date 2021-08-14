using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int vowels = CountVowels(word);

            Console.WriteLine(vowels);
        }

        private static int CountVowels(string word)
        {
            word = word.ToLower();
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    count++;
                }
                else if (word[i] == 'e')
                {
                    count++;
                }
                else if (word[i] == 'o')
                {
                    count++;
                }
                else if (word[i] == 'i')
                {
                    count++;
                }
                else if (word[i] == 'u')
                {
                    count++;
                }
                else if (word[i] == 'y')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
