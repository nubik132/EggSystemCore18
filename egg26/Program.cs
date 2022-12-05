using System;
using static egg26.egg26;

namespace egg26
{
    class egg26
    {
        static void Main()
        {
            GetMessage del;
            Console.WriteLine("Введите имя");
            del = Console.ReadLine;
            Console.WriteLine("Вас зовут " + del());
            Delegate del1;
            del1 = Kolich;
            Console.WriteLine(del1('а', "Первая встреча амогусов"));
            del1 = Firstindex;
            Console.WriteLine(del1('а', "Первая встреча амогусов"));
            symbols[] slark = new symbols[10];
            delegate1 del2;
            
            for (int i = 0; i < 10; i++)
            {
                slark[i] = new();
                del2 = slark[i].setchar;
                del2((char)(i+100));
                Console.Write(slark[i].f);
            }
            Console.WriteLine();
            indexator mam = new();
            Console.WriteLine(mam[2](9));

        }
        delegate string? GetMessage();
        delegate int Delegate(char a, string b);
        delegate void delegate1(char f);
        public delegate int Delegate2(int a);
        static int Kolich(char a, string b)
        {
            int count = 0;
            foreach (char item in b)
            {
                if (item == a) count++;
            }
            return count;
        }
        static int Firstindex(char a, string b)
        {
            return b.IndexOf(a);
        }
    }
    
    class symbols
    {
        public char f;
        public void setchar(char f)
        {
            this.f = f;
        }
        
    }
    class indexator
    {
        int index;
        public Delegate2 this[int index]
        {

            get
            {
                int chak(int x)
                {
                    return (int)Math.Pow(x, index);
                }
                this.index = index;
                return new egg26.Delegate2(chak);
            }
        }
    }
}