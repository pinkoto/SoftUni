using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double total = 0;
            if (type=="Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }

                total = people * price;

                if (people>=30)
                {
                    total *= 0.85;
                }

            }
            else if (type == "Buisness")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }

                total = people * price;

                if (people>=100)
                {
                    total = (people - 10) * price;
                }
            }
            else if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                
                total = people * price;

                if (people >=10&&people<=20)
                {
                    total *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {total:f2}");

        }
    }
}
