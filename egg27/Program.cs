namespace egg27
{
	class Program
	{
		static void Main()
		{
			Event a = new("a");
			Event b = new("b");
			Looker looker = new Looker();
			a.My_event += looker.Meth;
			b.My_event += looker.Meth;
			a.Create_Event();
			b.Create_Event();
		}
	}
	public delegate void MyDelegate(string a);
	class Event
	{
        public event MyDelegate My_event;
		string name;
		public Event(string name)
		{
			this.name = name;
		}
        public void Create_Event()
		{
            if (My_event != null) My_event("Заработало " + name + "!!!");
        }
    }
	class Looker
	{
		public void Meth(string a)
		{
			Console.WriteLine(a);
		}
	}
}