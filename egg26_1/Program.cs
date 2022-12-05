namespace egg26_1
{
	class Program
	{
		 static void Main()
		{
			del1 Men, Women, Both;
			Men = delegating;
			Women = delegatingtwo;
			Both = Men + Women;
			Random random = new();
			Men(random.Next(100));
			Women(random.Next(100));
			Both(random.Next(100));
		}
		delegate void del1(int a);
        public static void delegating(int a)
        {

			Console.WriteLine("Hello world! men count today " + a);

        }
		public static void delegatingtwo(int a)
		{
			Console.WriteLine("Bb world! women count today " + a);
		}
    }

}