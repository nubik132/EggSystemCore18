using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace egg31_1
{
    internal class Program
    {
        public delegate int TakesAWhileDelegate(int size, int elem);

        static void Main(string[] args)
        {
            TakesAWhileDelegate dl = Method;
            int size, elem;

            Console.Write("Введите размер массива: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите искомый элемент: ");
            elem = Convert.ToInt32(Console.ReadLine());

            IAsyncResult ar = dl.BeginInvoke(size, elem, null, null);
            while (!ar.IsCompleted)
            {
                Thread.Sleep(10);
                Console.Write(".");
            }
            Console.WriteLine(dl.EndInvoke(ar));
        }
        static int Method(int height, int width)
        {
            Console.WriteLine("I started!");
            Thread.Sleep(50);
            Random random = new Random();
            int[,] array = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = random.Next(20);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int result = 0;
            foreach (int item in array)
            {
                result += item;
            }
            Console.WriteLine("I finished");
            return result;
        }
    }
}
