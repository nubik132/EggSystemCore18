using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace egg31_Framework
{
    public delegate int TakesAWhileDelegate(int data, int ms);
    class Program
    {
        static void Main(string[] args)
        {
            TakesAWhileDelegate dl = Method;
            IAsyncResult ar = dl.BeginInvoke(2, 500, null, null);
            while (!ar.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.WriteLine(dl.EndInvoke(ar));
        }
        static int Method(int data, int ms)
        {
            Console.WriteLine("I started!");
            Thread.Sleep(ms);
            Console.WriteLine("I finished");
            return data * data;
        }
    }

}
