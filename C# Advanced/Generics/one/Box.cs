using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace one
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public List<T> Elements { get; }
        public T Element { get; }

        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elements)
        {
            Elements = elements;
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T elem in Elements)
            {
                sb.AppendLine($"{elem.GetType()}: {elem}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Swap(List<T> list, int first, int second)
        {
            T temp = list[first];
            list[first] = list[second];
            list[second] = temp;
        }

        public int CompareTo([AllowNull] T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T comparison) where T : IComparable
            => list.Count(w => w.CompareTo(comparison) > 0);
    }
}
