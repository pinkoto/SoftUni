using System;

namespace MidExamNew
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double pricePerKilo = double.Parse(Console.ReadLine());
            double pricePerPack = 0.75 * pricePerKilo;
            double pricePerLiter = 1.25 * pricePerKilo;
            double cozonakPrice = pricePerKilo + pricePerPack + 0.25 * pricePerLiter;
            int coloredEggs = 0;
            int cozonacs = 0;

            while (budget>=cozonakPrice)
            {
                budget -= cozonakPrice;
                cozonacs++;
                coloredEggs += 3;

                if (cozonacs%3==0)
                {
                    coloredEggs -= cozonacs - 2;
                }

            }

            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
