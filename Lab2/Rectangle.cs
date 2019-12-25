using System;

namespace Lab2
{
    class Rectangle : Figure, IPrint
    {
        double height, width;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = (value > 0) ? value : 0;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = (value > 0) ? value : 0;
            }
        }

        public Rectangle(double h, double w)
        {
            Width = w;
            Height = h;
            // this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return string.Format("Rectangle: Area = {0}.", Area());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
