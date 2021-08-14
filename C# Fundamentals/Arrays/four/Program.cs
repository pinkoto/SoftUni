using System;

namespace four
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine()) % numbers.Length;

            for (int i = 0; i < rotations; i++)
            {
                string firstNumber = numbers[0];
                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length - 1] = firstNumber;

            }

            foreach (string number in numbers)
            {
                Console.Write(number+" ");
            }
        }
    }
}
