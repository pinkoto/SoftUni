﻿using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }

        }
    }
}
