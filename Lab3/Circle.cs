using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Circle : Figure, IPrint
    {
        double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value > 0 ? value : 0;
            }
        }

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return string.Format("Circle: Area = {0}.", Area());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
