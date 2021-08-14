using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Threeuple<TFirst,TSecond,TThird>
    {
        public TFirst FirstElement { get;private set; }

        public TSecond SecondElement { get; private set; }

        public TThird ThirdElement { get; private set; }

        public Threeuple(TFirst first, TSecond second,TThird third)
        {
            FirstElement = first;
            SecondElement = second;
            ThirdElement = third;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }
}
