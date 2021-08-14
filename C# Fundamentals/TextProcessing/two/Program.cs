using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string first = words[0];
            string second = words[1];
            int n = Math.Min(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length >second.Length)
            {
                for (int i = n; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            else if (first.Length < second.Length)
            {
                for (int i = n; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
