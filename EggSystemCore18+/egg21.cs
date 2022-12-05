using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggSystemCore18_
{
    internal class egg21
    {
        public static void Prog()
        {
            try
            {
                Console.Write("a="); double a = double.Parse(Console.ReadLine());
                Console.Write("b="); double b = double.Parse(Console.ReadLine());
                Console.Write("h="); double h = double.Parse(Console.ReadLine());

                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
        static double f(double x)
        {
            if(!(x*x<1))
                    return Math.Sqrt(x * x - 1);
            else
            throw new ArithmeticException();
        }
    }
}
