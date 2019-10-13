using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Сахарова Елизавета ИУ5-32Б";
            Console.WriteLine("ax^4 + bx^2 + c = 0.\nВведите коэффициенты a, b, c биквадратного уравнения: ");
            Console.Write("a = ");
            double aCoefficient;
            while (!double.TryParse(Console.ReadLine(), out aCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неверный ввод данных. Попробуйте ещё раз.\n");
                Console.ResetColor();
                Console.Write("a = ");
            }
            Console.Write("b = ");
            double bCoefficient;
            while (!double.TryParse(Console.ReadLine(), out bCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неверный ввод данных. Попробуйте ещё раз.\n");
                Console.ResetColor();
                Console.Write("b = ");
            }
            Console.Write("c = ");
            double cCoefficient;
            while (!double.TryParse(Console.ReadLine(), out cCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неверный ввод данных. Попробуйте ещё раз.\n");
                Console.ResetColor();
                Console.Write("c = ");
            }

            if (aCoefficient != 0)
            {
                double Discriminant = Math.Pow(bCoefficient, 2) - 4 * aCoefficient * cCoefficient;
                if (Discriminant < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Уравнение не имеет действительных корней."); 
                }
                else if (Discriminant == 0)
                {
                    double rootT = (-bCoefficient) / (2 * aCoefficient);
                    if (rootT > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни уравнения: {0}, {1}.", Math.Sqrt(rootT), -Math.Sqrt(rootT));
                    }
                    else if (rootT == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корень уравнения: 0.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет корней.");
                    }
                }
                else
                {
                    double rootT1 = (-bCoefficient + Math.Sqrt(Discriminant)) / (2 * aCoefficient);
                    double rootT2 = (-bCoefficient - Math.Sqrt(Discriminant)) / (2 * aCoefficient);
                    if (rootT1 < 0 && rootT2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Уравнение не имеет корней.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (rootT1 > 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("Корни уравнения: {0}, {1}, {2}, {3}.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1), Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else if (rootT2 == 0)
                            {
                                Console.WriteLine("Корни уравнения: {0}, {1}, 0.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1));
                            }
                            else
                            {
                                Console.WriteLine("Корни уравнения: {0}, {1}.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1));
                            }
                        }
                        else if (rootT1 == 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("Корни уравнения: 0, {0}, {1}.", Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else
                            {
                                Console.WriteLine("Корень уравнения: 0.");
                            }
                        }
                        else if (rootT1 < 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("Корни уравнения: {0}, {1}.", Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else if (rootT2 == 0)
                            {
                                Console.WriteLine("Корень уравнения: 0.");
                            }
                        }
                    }

                }
            }
            else
            {
                if (bCoefficient != 0)
                {
                    double rootT = cCoefficient / bCoefficient;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (rootT == 0)
                    {
                        Console.WriteLine("Корень уравнения: 0.");
                    }
                    else
                    {
                        Console.WriteLine("Корни уравнения: {0}, {1}.", Math.Sqrt(rootT), -Math.Sqrt(rootT));
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Уравнение не имеет корней.");
                }
            }
            Console.ReadLine();
        }
    }
}
