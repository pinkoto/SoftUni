using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int smallestNum=  FindMin(first, second, third);
            
            Console.WriteLine(smallestNum);
        }

        private static int FindMin(int first, int second, int third)
        {
            return Math.Min(Math.Min(first, second), third);
        }
    }
}
