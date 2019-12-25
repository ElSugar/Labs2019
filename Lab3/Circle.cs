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

        public Circle(double _radius)
        {
            this.radius = _radius;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double _area = Math.Pow(this.radius, 2) * Math.PI;
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
