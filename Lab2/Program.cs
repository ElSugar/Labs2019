using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сахарова Елизавета ИУ5-32Б";
            Rectangle _rectangle = new Rectangle(5, 4);
            Square _square = new Square(5);
            Circle _circle = new Circle(5);

            _rectangle.Print();
            _square.Print();
            _circle.Print();

            Console.ReadLine();
        }
    }
}
