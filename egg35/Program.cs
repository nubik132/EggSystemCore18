namespace egg35
{
	class Program
	{
		static void Main(string[] args)
		{
			Nums num1 = new(1, 2), num2 = new(3, 4), result;
			MyClass<Nums> obj1 = new(num1, num2);
            MyClass<Nums> obj2 = new(num1, num2);
			result = obj1 + obj2;
            Console.WriteLine(result.a);
            Console.WriteLine(result.b);
            Console.WriteLine("--------------------------------------------");
            int[] a = new int[] { 1, 2, 6 };
            int[] b = new int[] { 3, 4, 5 };
            foreach (var item in Cop<int>.Copy(a, b, 2))
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine(Cop<char>.Copy("кара".ToCharArray(), "пиба".ToCharArray(), 2));
        }
    }
	class  Cop<T>
    {
		public static T[] Copy(T[] one, T[] two, int pos)
		{
            T[] three = new T[one.Length + two.Length];
			for (int i = 0; i < pos; i++)
				three[i] = one[i];
			for (int i = 0; i < two.Length; i++)
				three[i + pos] = two[i];
			for (int i = pos; i < one.Length; i++)
				three[i + two.Length] = one[i];
			return three;
		}
	}
	class MyClass<T> where T: Nums 
	{
		public T obj1, obj2;
		public MyClass(T a, T b)
		{
            obj1 = a;
            obj2 = b;
		}
		public static Nums operator +(MyClass<T> a, MyClass<Nums> b)
		{
			return new Nums(a.obj1.a + b.obj2.a, b.obj1.b + b.obj2.b);
		}
	}
	class Nums
	{
		public int a, b;
		public Nums(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
	}
}