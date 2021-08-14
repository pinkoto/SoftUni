using System;

namespace seven
{
    class Program
    {
        static void Main(string[] args)
        {

            int volume = 255;
            int sips = int.Parse(Console.ReadLine());

            for (int i = 0; i < sips; i++)
            {
                int poured = int.Parse(Console.ReadLine());

                if (poured <= volume)
                {
                    volume -= poured;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(255 - volume);
        }
    }
}
