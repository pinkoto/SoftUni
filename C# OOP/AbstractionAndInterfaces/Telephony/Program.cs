using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var urlsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StationaryPhone stationary = new StationaryPhone();
            Smartphone smartphone = new Smartphone();
            for (int i = 0;  i < numbersInput.Length;  i++)
            {
                var number = numbersInput[i];
                if (number.Length==7)
                {
                    try
                    {
                        stationary.Dial(number);
                    }
                    catch (ArgumentException ae )
                    {
                        Console.WriteLine(ae.Message); 
                    }
                }
                else if (number.Length==10)
                {
                    try
                    {
                        smartphone.Dial(number);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }
            for (int i = 0; i < urlsInput.Length; i++)
            {
                try
                {
                smartphone.Browse(urlsInput[i]);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
