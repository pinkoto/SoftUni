using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] people = new int[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write(people[j] + " ");
                sum += people[j];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
