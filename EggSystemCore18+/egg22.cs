namespace EggSystemCore18_
{
    class egg22
    {
        public static void Prog()
        {
            //int n = 0;
            //try
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введено не число");
            //}
            //int sum = 0;
            //for (int i = 5; i / 5 <= n; i += 5)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //---------------------------------------------------------
            //double a = 0, s = 1;
            //try
            //{
            //    a = Convert.ToDouble(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введено не число");
            //}
            //if (a >= 0)
            //{
            //    for (int i = 2; i <= 8; i += 2)
            //    {
            //        s = s * Math.Pow(i, 2);
            //    }
            //    s -= a;
            //}
            //else
            //{
            //    int i = 3;
            //    s = 0;
            //    do
            //    {
            //        s += i - 2;
            //        i += 3;
            //    } while (i <= 9);
            //}
            //Console.WriteLine(s);
            //-----------------------------------------------------------
            //double sum = 0, x, a;
            //double step = 0, aPlusOne;
            //try
            //{
            //    step = Convert.ToDouble(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введено не число");
            //}
            //x = step;
            //a = S(x, 0);
            //sum = a;
            //for (int n = 0; x <= 1; n++, x = step * (n + 1))
            //{
            //    aPlusOne = a * S(x, n);
            //    sum += aPlusOne;
            //    a = aPlusOne;
            //    Console.Write($"x={x}\t");
            //    Console.Write(sum + "\t");
            //    Console.WriteLine(Math.Sin(x));
            //}
            //An+1 = An * D(x,n)
            //------------------------------------------------------------
            //int n = 0;
            //double x = 0, y = 0;
            //try
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    x = Convert.ToDouble(Console.ReadLine());
            //    if (n < 0)
            //        throw new Exception();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введено не число");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("n < 0");
            //}
            //for (int i = 0; i <= n; i++)
            //{
            //    y += Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Fact(2 * i);
            //}
            //Console.WriteLine(y);
            double step = Convert.ToDouble(Console.ReadLine());
            const int n = 10;
            Console.Write($" x\t");
            Console.Write($"\t  S(x, n)\t");
            Console.Write($"sin\n");

            for (double x = 0; x <= 1; x += step)
            {
                double anPlusOne = 0;
                double an = 1;
                double sum = 0;

                for (int i = 0; i <= n; i++)
                {
                    anPlusOne = S(x, i) * an;
                    an = anPlusOne;
                    sum += anPlusOne;
                }
                Console.Write($"{x: 0.000000}\t");
                Console.Write($"{sum:  0.000000}\t");
                Console.Write($"{Math.Sin(x):0.000000}\n");
            }
        }
        static int Fact(double a)
            {
                int result = 1;
                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }
                return result;
            }
            static double S(double x, double n)
            {
                return Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1) / Fact(2 * n + 1));
            }
            static double D(double x, double n)
            {
                return -1 * ((x * x) / ((2 * n + 2) * (2 * n + 3)));
            }
        }
    }
