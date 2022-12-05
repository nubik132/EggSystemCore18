using System;
namespace EggSystemCore18_
{
    internal class egg18Hilch
    {
        public static void Prog()
        {
            ClassHilcko obj = new("obj");
            I1 inter1;
            I2 inter2;
            inter1 = new ClassHilcko("inter1");
            inter2 = new ClassHilcko("inter2");
            Console.WriteLine("{0}\n{1}\n{2}",
                obj.a,
                inter1.a,
                inter2.a);
        }
    }
    interface I1
    {
        public string a { get; }
    }
    interface I2
    {
        public string a { get; }
    }
    class ClassHilcko : I1, I2
    {
        string b;
        public ClassHilcko(string b)
        {
            this.b = b;
        }

        public string a { get => b; }
        string I2.a { get => b; }
    }
}
