namespace egg29
{
    public class Lab
    {
        static Thread thread1, thread2, thread3;

        public static void Main()
        {
            thread1 = new Thread(ThreadProc);
            thread1.Name = "Thread1";
            thread1.Start();

            thread2 = new Thread(ThreadProc);
            thread2.Name = "Thread2";
            thread2.Start();

            thread3 = new Thread(ThreadProc);
            thread3.Name = "Thread3";
            thread3.Start();
        }

        private static void ThreadProc()
        {
            Console.WriteLine("\nТекущий поток: {0}", Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name == "Thread1" &&
                thread2.ThreadState != ThreadState.Unstarted)
            {
                thread2.Join();
                thread3.Join();
            }

            Thread.Sleep(1000);
            Console.WriteLine("\nТекущий поток: {0}", Thread.CurrentThread.Name);
            Console.WriteLine("Поток 1: {0}", thread1.ThreadState);
            Console.WriteLine("Поток 2: {0}\n", thread2.ThreadState);
            Console.WriteLine("Поток 3: {0}\n", thread2.ThreadState);
        }
    }
}