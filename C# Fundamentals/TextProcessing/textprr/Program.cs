using System;

using System.Linq;
using System.Text;

namespace textprr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (isValid(usernames[i]) && usernames[i].Length > 3 && usernames[i].Length < 16)
                {
                    Console.WriteLine(usernames[i] + " ");
                }
            }
        }

        private static bool isValid(string name)
        {
            foreach (char symbol in name)
            {
                if (!char.IsLetterOrDigit(symbol) &&
                    symbol != '_' &&
                    symbol != '-')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
