using System;

namespace Loginl
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = "";

            for (int i = name.Length-1; i >= 0; i--)
            {
                pass += name[i];
            }

            int failed = 0;

            while (failed <= 4)
            {
                string pInput = Console.ReadLine();
                
                if (pInput == pass)
                {
                    Console.WriteLine($"User {name} logged in.");
                    break;
                }
                else
                {
                    failed++;
                    if (failed == 4)
                    {
                        Console.WriteLine($"User {name} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
