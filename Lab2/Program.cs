using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сахарова Елизавета ИУ5-32Б";
            Rectangle _rectangle = new Rectangle(3, 5);
            _rectangle.Print();

            Square _square = new Square(4);
            _square.Print();

            Circle _circle = new Circle(2.0);
            _circle.Print();

            Console.ReadLine();
        }
    }
}
