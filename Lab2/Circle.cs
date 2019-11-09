using System;

namespace Lab2
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
            return this.Type + " имеет площадь " + this.Area().ToString();
            // this line return this.Type has an area equal to this.Area().ToString()
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
