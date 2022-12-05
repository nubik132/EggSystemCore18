using System;
using System.Threading;
namespace egg29_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread thread1 = new(PrintHashcode);
            Thread thread2 = new(PrintHashcode);
            Thread thread3 = new(PrintHashcode);
			thread1.Name = "Thread 1";
            thread2.Name = "Thread 2";
            thread3.Name = "Thread 3";
			thread1.Start();
			thread2.Start();
			thread3.Start();
            Thread.Sleep(100);

            Thread threadSleep1 = new(new ParameterizedThreadStart(PrintHashcodeSleep));
            Thread threadSleep2 = new(PrintHashcodeSleep);
            Thread threadSleep3 = new(PrintHashcodeSleep);
            threadSleep1.Name = "Thread sleep 1";
            threadSleep2.Name = "Thread sleep 10";
            threadSleep3.Name = "Thread sleep 0";
            threadSleep1.Start(1);
            threadSleep2.Start(10);
            threadSleep3.Start(0);
            Thread.Sleep(100);

            Thread threadPriority1 = new(PrintHashcode);
            Thread threadPriority2 = new(PrintHashcode);
            Thread threadPriority3 = new(PrintHashcode);
            threadPriority1.Name = "Thread Priority 1 Lowest";
            threadPriority2.Name = "Thread Priority 2 Normal";
            threadPriority3.Name = "Thread Priority 3 Highest";
            threadPriority1.Priority = ThreadPriority.Highest;
            threadPriority2.Priority = ThreadPriority.Normal;
            threadPriority3.Priority = ThreadPriority.Lowest;
            threadPriority1.Start();
            threadPriority2.Start();
            threadPriority3.Start();
        }
        static void PrintHashcode()
		{
			Console.WriteLine(Thread.CurrentThread.Name + '\n'
				+ Thread.CurrentThread.GetHashCode() + '\n');
		}
        static void PrintHashcodeSleep(object? time)
        {
            Thread.Sleep((int)time);
            Console.WriteLine(Thread.CurrentThread.Name + '\n'
                + Thread.CurrentThread.GetHashCode() + '\n');
        }
    }
}