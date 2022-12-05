using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggSystemCore18_
{
    internal class egg20
    {
        static public void Prog()
        {
            Class20 obj = new();
            try
            {
                obj.CreateC();
            }
            catch (DivideByZeroException) { Console.WriteLine("Деление на 0"); }
            try { obj.CreateD(); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Переполнение массива"); }
            try { obj.CreateC(); }
            catch (ArithmeticException) { Console.WriteLine("Арифметическое исключение"); }
            catch (OutOfMemoryException) { Console.WriteLine("Нехватка памяти"); }
        }
        class Class20
        {
            const int SIZE = 10;
            int[] a, b, c, d;
            public Class20()
            {
                Random random = new Random();
                a = new int[SIZE];
                b = new int[SIZE];
                for (int i = 0; i < SIZE; i++)
                {
                    a[i] = random.Next(4);
                    b[i] = random.Next(4);
                }
            }
            public void CreateC()
            {
                c = new int[SIZE];
                Array.Copy(a, c, SIZE);
                for (int i = 0; i < SIZE; i++)
                {
                    c[i] /= b[i];
                }
            }
            public void CreateD()
            {
                d = new int[SIZE];
                for (int i = 0; i < SIZE * 2; i += 2)
                {
                    d[i] = a[i / 2];
                    d[i + 1] = b[i / 2];
                }
            }
        }
    }
}
