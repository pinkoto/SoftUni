using System;
using System.Linq;

namespace Telephony
{
    public class StationaryPhone : IDialable
    {
        public void Dial(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
