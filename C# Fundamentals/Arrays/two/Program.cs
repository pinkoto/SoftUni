using System;

namespace two
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string secondElem in secondArray)
            {
                foreach (string firstElem in firstArray)
                {
                    if (firstElem==secondElem)
                    {
                        Console.Write(secondElem+" ");
                    }
                }
            }
        }
    }
}
