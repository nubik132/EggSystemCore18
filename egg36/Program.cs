namespace egg36
{
    delegate string Deleg<T, K>(T? separator, K?[] values);
    delegate void DelegEvent(string str);
    class Prog
    {
        static void Main(string[] args)
        {
            Deleg<char, int> delegCharInt = String.Join;
            int[] intArray = { 1, 2, 3, 4 };
            Console.WriteLine(delegCharInt(' ', intArray));

            Deleg<string, char> delegStringChar = String.Join;
            char[] symbs = { 'A', 'B', 'C' };
            Console.WriteLine(delegStringChar(" ☺ ", symbs));

            Console.WriteLine("----------------------------");

            MyClass obj1 = new("obj1");
            MyClass obj2 = new("obj2");

            SecondClass secClassObj = new();

            obj1.Event += secClassObj.Method;
            obj2.Event += secClassObj.Method;

            obj1.CreateEvent(); obj2.CreateEvent();
        }
    }
    class MyClass
    {
        public event DelegEvent Event;
        string name;
        public MyClass(string name)
        {
            this.name = name;
        }
        public void CreateEvent() => Event(name);
    }
    class SecondClass
    {
        public void Method(string str) => Console.WriteLine(str);
    }
}