using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public abstract class MyValdationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
