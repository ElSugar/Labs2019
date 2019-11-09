using System;

namespace Lab2
{
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;

        /// <summary>
        /// The main constructor
        /// </summary>
        /// <param name="_height">Height</param>
        /// <param name="_width">Width</param>
        public Rectangle(double _height, double _width)
        {
            this.height = _height;
            this.width = _width;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double _area = this.width * this.height;
            return _area;
        }

        public override string ToString()
        {
            return this.Type + " имеет площадь " + this.Area().ToString();
            // this line return this.Type has an area equal to this.Area().ToString()
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
