using System;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string mvName = "";
            
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(r, 2) * h;
                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    mvName = name;
                }
            }

            Console.WriteLine(mvName);
        }
    }
}
