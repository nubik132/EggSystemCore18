using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggSystemCore18_
{
    internal class egg19
    {
        static public void Prog()
        {
            Class19 obj = new();
            try
            {
                obj.pub = 1;
                Console.WriteLine(obj.pub);
                obj.inter = 2;
                Console.WriteLine(obj.inter);
                obj.SetProt(3);
                Console.WriteLine(obj.GetProt());
                obj.PrintProt();
                obj.SetPriv(4);
                Console.WriteLine(obj.GetPriv());
                obj.PrintPriv();
            }
            catch (Exception)
            {
                Console.WriteLine("Упс! Что-то пошло не так!");
            }
        }
    }
    class Class19
    {
        public int pub = 0;
        internal int inter = 0;
        protected int prot = 0;
        private int priv = 0;
        public int GetProt()
        {
            return prot;
        }
        public void SetProt(int a)
        {
            prot = a;
        }
        public void PrintProt()
        {
            Console.WriteLine(prot);
        }
        public int GetPriv()
        {
            return priv;
        }
        public void SetPriv(int a)
        {
            priv = a;
        }
        public void PrintPriv()
        {
            Console.WriteLine(priv);
        }
    }
}
