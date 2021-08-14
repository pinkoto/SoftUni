using System;
using System.Collections.Generic;
using System.Linq ;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            List <string> result = new List<string>();
            int remains = 0;

            for (int i = number.Length - 1;i >= 0; i--)
            {
                int digit = number[i] - '0';
                int multiplication = digit * multiplyer+remains;
                remains = multiplication / 10;
                int digitToAdd = multiplication % 10;


                result.Add(digitToAdd.ToString());
            }

            result.Reverse();

            if (remains>0)
            {
                result.Insert(0, remains.ToString());
            }

            Console.WriteLine(string.Concat(result)); 
        }
    }
}
