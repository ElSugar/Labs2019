using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сахарова Елизавета ИУ5-32Б";

            Rectangle rectangle = new Rectangle(6, 4);
            Square square = new Square(5);
            Circle circle = new Circle(7);

            // ArrayList
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(circle);
            arrayList.Add(rectangle);
            arrayList.Add(square);

            foreach (var x in arrayList) Console.WriteLine(x);

            Console.WriteLine("\nОтсортированный ArrayList");
            arrayList.Sort();

            foreach (var x in arrayList) Console.WriteLine(x);

            // List<Figure>
            Console.WriteLine("\nList<Figure>");
            List<Figure> figureList = new List<Figure>();
            figureList.Add(circle);
            figureList.Add(rectangle);
            figureList.Add(square);

            foreach (var x in figureList) Console.WriteLine(x);

            Console.WriteLine("\nОтсортированный List<Figure>");
            arrayList.Sort();

            foreach (var x in arrayList) Console.WriteLine(x);

            // Matrix<Figure>
            Console.WriteLine("\nMatrix<Figure>");
            Matrix<Figure> matrix = new Matrix<Figure>(2, 2, 2, square);
            Console.WriteLine(matrix.ToString());

            // SimpleList<Figure>
            Console.WriteLine("SimpleList<Figure>");
            SimpleList<Figure> list = new SimpleList<Figure>();
            list.Add(square);
            list.Add(rectangle);
            list.Add(circle);

            foreach (var x in list) Console.WriteLine(x);

            Console.WriteLine("\nОтсортированный SimpleList<Figure>");
            list.Sort();

            foreach (var x in list) Console.WriteLine(x);

            // SimpleStack<Figure>
            Console.WriteLine("\nSimpleStack<Figure>");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rectangle);
            stack.Push(square);
            stack.Push(circle);

            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadKey();

        }
    }
}