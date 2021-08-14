using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double width;
        private double length;
        private double height;

        public double Width
        {
            get { return width; }
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box()
        {

        }

        public Box(double l, double w, double h)
        {
            Length = l;
            Width = w;
            Height = h;
        }

        public double Volume() => width * height * length;

        public double SurfaceArea() => 2 * (length * height + length * width + height * width);

        public double LateralSurfaceArea() => 2 * (length * height + width * height);
    }
}
