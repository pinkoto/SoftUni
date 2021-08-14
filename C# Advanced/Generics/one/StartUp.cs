using System;
using System.Collections.Generic;
using System.Linq;

namespace one
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int linesToRead = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < linesToRead; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<double>(list);
            var comparable = double.Parse(Console.ReadLine());
            var count = box.CountOfGreaterElements(list, comparable);
            Console.WriteLine(count);
        }
    }
}
