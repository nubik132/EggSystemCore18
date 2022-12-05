using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace egg31_3
{
    public delegate bool TakesAWhileDelegate(int size, int elem);
    class Program
    {
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
        static bool Method(int size, int elem)
        {
            Console.WriteLine("I started!");
            Thread.Sleep(50);
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(size);
            }
            for (int i = 0; i < size; i++)
                if (array[i] == elem)
                {
                    Console.WriteLine("I finished");
                    return true;
                }
            Console.WriteLine("I finished");
            return false;
        }
    }
}
