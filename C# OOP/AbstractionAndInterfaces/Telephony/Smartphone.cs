﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IDialable, IBrowsable
    {
        public void Browse(string url)
        {
            if (url.Any(x=>char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Dial(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Calling... {number}");
        }
    }
}
