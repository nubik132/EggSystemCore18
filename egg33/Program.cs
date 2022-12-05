namespace egg33
{
	class Program
	{
		static void Main(string[] args)
		{
			AdultCow cow = new AdultCow();
			LittleCow littleCow = new LittleCow();
			cow.GiveMilk();
			cow.Eat();
			cow.GiveMilk();
			littleCow.GiveMilk();
			littleCow.Eat();
		}
        #region AbstractCow
        abstract class AbstractCow
		{
			abstract public void GiveMilk();
            abstract public void Eat();
        }
        #endregion
        #region AdultCow
        class AdultCow : AbstractCow
		{
			bool isHaveMilk = false;
			public override void GiveMilk()
			{
				if(isHaveMilk)
					Console.WriteLine("Корова дала 5 литров молока");
#if DEBUG
					Console.WriteLine("Маловато");
#endif
				isHaveMilk = false;
			}
            public override void Eat()
			{
				Console.WriteLine("Корова поела");
				isHaveMilk = true;
			}
		}
        #endregion
        #region LittleCow
        class LittleCow : AbstractCow
		{
            public override void GiveMilk()
			{
				Console.WriteLine("Телёнок не может дать молоко");
			}
            public override void Eat()
			{
				Console.WriteLine("Телёнок подрос");
			}
        }
        #endregion
    }
}