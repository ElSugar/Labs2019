using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
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
            return this.Type + " площадью " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
