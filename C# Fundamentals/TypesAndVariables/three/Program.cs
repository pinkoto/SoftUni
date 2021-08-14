using System;

namespace three
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = 0;

            while (n > 0)
            {
                courses++;
                n -= p;

            }

            Console.WriteLine(courses);
        }
    }
}
