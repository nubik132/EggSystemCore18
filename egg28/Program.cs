namespace egg28
{

    class Program
    {
        public delegate int[] MathDelegate(int[] a);
        static void Main()
        {
            MathDelegate md;
            md = (int[] a) =>
            {
                int b;
                for (int i = 0; i < a.Length / 2; i++)
                {
                    b = a[i];
                    a[i] = a[a.Length - i - 1];
                    a[a.Length - i - 1] = b;
                }
                return a;
            };
            Random random = new Random();
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(10);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            md(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }

}