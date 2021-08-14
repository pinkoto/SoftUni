using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = personInfo[2];

            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var liters = int.Parse(nameAndBeer[1]);
            var drunk = nameAndBeer[2] == "drunk" ? true : false;

            var numbersInput = Console.ReadLine().Split();
            var intNum = numbersInput[0];
            var doubleNum = double.Parse(numbersInput[1]);

            Threeuple<string, string, string> fTuple = new Threeuple<string, string, string>(fullName, city, personInfo[3]);
            Threeuple<string, int, bool> sTuple = new Threeuple<string, int, bool>(name, liters, drunk);
            Threeuple<string, double, string> tuple = new Threeuple<string, double, string>(intNum, doubleNum, numbersInput[2]);

            Console.WriteLine(fTuple);
            Console.WriteLine(sTuple);
            Console.WriteLine(tuple);
        }
    }
}
