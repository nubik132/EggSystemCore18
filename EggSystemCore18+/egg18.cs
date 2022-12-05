using System;

namespace EggSystemCore18_
{
    internal class egg18
    {
        static public void Prog()
        {
            Class obj = new("Строка");
            Console.WriteLine(obj.RetChar(1));
            obj.Meth("Не строка");
            Console.WriteLine(obj.RetChar(1));
            obj.Meth(1, 'у');
            Console.WriteLine(obj.RetChar(1));
            obj[1] = 'c';
            Console.WriteLine(obj[1]);
        }
    }
    public abstract class abstrclass
    {
        protected char[] mas;
        public abstrclass(string mas)
        {
            this.mas = mas.ToArray();
        }
        public char RetChar(int i)
        {
            return mas[i];
        }
        public abstract void Meth(int a, char b);
    }
    interface Chack
    {
        public void Meth(string a);
        char this[int a]
        {
            get => this[a];
            set { this[a] = value; }
        }
    }
    public class Class: abstrclass, Chack
    {
        public Class(string mas) : base(mas)
        {
        }
        public override void Meth(int a, char b)
        {
            mas[a] = b;
        }
        public void Meth(string a)
        {
            this.mas = a.ToArray();
        }
        public char this[int a]
        {
            get => mas[a];
            set { mas[a] = value; }
        }
    }
}
//valdik[2] = 'a';