using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValdationAttribute
    {
        private int _minValue;
        private int _maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException();
            }

            int intObj = (int)obj;
            bool isInRange = intObj >= _minValue && intObj <= _maxValue;
            if (!isInRange)
            {
                return false;
            }

            return true;
        }
    }
}
