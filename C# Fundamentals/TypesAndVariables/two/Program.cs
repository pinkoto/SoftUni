using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num>0)
            {
                int last = num % 10;
                sum += last;
                num /= 10;
            }
            
            Console.WriteLine(sum);
        }
    }
}
