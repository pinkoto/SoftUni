using System;
using System.Text;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            char lastSymbol = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol!=lastSymbol)
                {
                    lastSymbol = currentSymbol;
                    sb.Append(currentSymbol);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
