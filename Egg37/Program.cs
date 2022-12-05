namespace Egg37
{
	class Prog
	{
		static void Main()
		{
			MyClass a = new(5);
			a.Print();
			Console.WriteLine();
			List<MyClass> b = new List<MyClass>(5);
			for (int i = 4; i > -1; i--)
			{
				b.Add(new(i));
				b[4-i].Print();
			}
			Console.WriteLine();
			b.Sort();
			foreach (var item in b)
				item.Print();
		}
	}
	class MyClass : IComparable<MyClass> 
	{
		double c;
		public MyClass(double c)
		{
			this.c = c;
		}
		public int CompareTo(MyClass? a)
		{
			if (a is MyClass b) return c.CompareTo(b.c);
			return 0;
		}
		public void Print()
		{
			Console.Write(" " + c + " ");
		}
	}
}