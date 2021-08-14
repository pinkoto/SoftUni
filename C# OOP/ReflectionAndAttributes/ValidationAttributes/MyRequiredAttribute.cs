using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValdationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
