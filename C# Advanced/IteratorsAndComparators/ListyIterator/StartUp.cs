using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listy = null;

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0]=="END")
                {
                    break;
                }

                if (tokens[0] == "Create")
                {
                    listy = new ListyIterator<string>(tokens.Skip(1).ToArray());
                }
                else if (tokens[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (tokens[0] == "Print")
                {
                    listy.Print();
                }
                else if (tokens[0] =="PrintAll")
                {
                    listy.PrintAll();
                }
                else if (tokens[0]=="HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
            }
        }
    }
}
