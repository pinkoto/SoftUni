using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if (start >end)
            {
                char temp = end;
                end = start;
                start = temp;
            }

            PrintSequence(start, end);
        }

        private static void PrintSequence(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}
