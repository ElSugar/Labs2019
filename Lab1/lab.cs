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
            Console.Title = "�������� ��������� ��5-32�";
            Console.WriteLine("ax^4 + bx^2 + c = 0.\n������� ������������ a, b, c ������������� ���������: ");
            Console.Write("a = ");
            double aCoefficient;
            while (!double.TryParse(Console.ReadLine(), out aCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("�������� ���� ������. ���������� ��� ���.\n");
                Console.ResetColor();
                Console.Write("a = ");
            }
            Console.Write("b = ");
            double bCoefficient;
            while (!double.TryParse(Console.ReadLine(), out bCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("�������� ���� ������. ���������� ��� ���.\n");
                Console.ResetColor();
                Console.Write("b = ");
            }
            Console.Write("c = ");
            double cCoefficient;
            while (!double.TryParse(Console.ReadLine(), out cCoefficient))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("�������� ���� ������. ���������� ��� ���.\n");
                Console.ResetColor();
                Console.Write("c = ");
            }

            if (args.Length == 3)
            {
                try
                {
                    aCoefficient = Convert.ToDouble(args[0]);
                    bCoefficient = Convert.ToDouble(args[1]);
                    cCoefficient = Convert.ToDouble(args[2]);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("�������� ���� ������.\n");
                    Console.ResetColor();
                    return;
                }
            }

            if (aCoefficient != 0)
            {
                double Discriminant = Math.Pow(bCoefficient, 2) - 4 * aCoefficient * cCoefficient;
                if (Discriminant < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("��������� �� ����� �������������� ������."); 
                }
                else if (Discriminant == 0)
                {
                    double rootT = (-bCoefficient) / (2 * aCoefficient);
                    if (rootT > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("����� ���������: {0}, {1}.", Math.Sqrt(rootT), -Math.Sqrt(rootT));
                    }
                    else if (rootT == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("������ ���������: 0.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("��������� �� ����� �������������� ������.");
                    }
                }
                else
                {
                    double rootT1 = (-bCoefficient + Math.Sqrt(Discriminant)) / (2 * aCoefficient);
                    double rootT2 = (-bCoefficient - Math.Sqrt(Discriminant)) / (2 * aCoefficient);
                    if (rootT1 < 0 && rootT2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("��������� �� ����� �������������� ������.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (rootT1 > 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("����� ���������: {0}, {1}, {2}, {3}.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1), Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else if (rootT2 == 0)
                            {
                                Console.WriteLine("����� ���������: {0}, {1}, 0.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1));
                            }
                            else
                            {
                                Console.WriteLine("����� ���������: {0}, {1}.", Math.Sqrt(rootT1), -Math.Sqrt(rootT1));
                            }
                        }
                        else if (rootT1 == 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("����� ���������: 0, {0}, {1}.", Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else
                            {
                                Console.WriteLine("������ ���������: 0.");
                            }
                        }
                        else if (rootT1 < 0)
                        {
                            if (rootT2 > 0)
                            {
                                Console.WriteLine("����� ���������: {0}, {1}.", Math.Sqrt(rootT2), -Math.Sqrt(rootT2));
                            }
                            else if (rootT2 == 0)
                            {
                                Console.WriteLine("������ ���������: 0.");
                            }
                        }
                    }

                }
            }
            else
            {
                if (bCoefficient != 0)
                {
                    double rootT = -cCoefficient / bCoefficient;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (rootT == 0)
                    {
                        Console.WriteLine("������ ���������: 0.");
                    }
                    else
                    {
                        Console.WriteLine("����� ���������: {0}, {1}.", Math.Sqrt(rootT), -Math.Sqrt(rootT));
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("��������� �� ����������.");
                }
            }
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}