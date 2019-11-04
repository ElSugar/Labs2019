using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сахарова Елизавета ИУ5-32Б";
            int a = 0, b = 0;

            // Enter the sizes of the rectangle
            Console.Write("Введите стороны прямоугольника:\na = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Rectangle _rectangle = new Rectangle(a, b);
            _rectangle.Print();

            // Enter the size of the square
            Console.Write("\nВведите сторону квадрата:\na = ");
            a = int.Parse(Console.ReadLine());
            Square _square = new Square(a);
            _square.Print();

            //Enter the radius of the circle
            Console.Write("\nВведите радиус окружности:\nr = ");
            a = int.Parse(Console.ReadLine());
            Circle _circle = new Circle(a);
            _circle.Print();

            Console.ReadLine();
        }
    }
}
