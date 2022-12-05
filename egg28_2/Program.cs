using System.Collections;

namespace egg28_2
{
	class Program
	{
		delegate string Func(ArrayList list);
		static void Main(string[] args)
		{
			Func solveKratnost, findIndex;
			solveKratnost = array =>
			{
				string answer = "";
				int kratnost;
				kratnost = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < array.Count; i++)
					answer += (int)array[i] % kratnost == 0 && (int)array[i] != 0 ? array[i].ToString() + " " : "";
				return answer;
			};

			findIndex = array =>array[Convert.ToInt32(Console.ReadLine())].ToString();

			int SIZE = 10;
            Random random = new Random();
            ArrayList list = new();
			string num = "";
			for (int i = 0; i < SIZE; i++)
			{
				list.Add(random.Next(SIZE));
			}
			while (true)
			{
				Console.WriteLine("1. Кратность числа\n2. Поиск по индесу");
				num = Console.ReadLine();
				if (num == "1")
					Console.WriteLine(solveKratnost(list));
				else if (num == "2")
					Console.WriteLine(findIndex(list));
				else
					continue;
			}
		}
	}
}