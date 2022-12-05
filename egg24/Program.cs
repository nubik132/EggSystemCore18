using System;
using System.IO;
namespace egg24
{
	class egg24
	{
		static void Main()
		{
			try
			{
				if (File.Exists("E:\\txt2.txt"))
				{
					StreamReader reader = new("E:\\txt2.txt");
					string[] sent = new string[3];
					string str = reader.ReadToEnd();
					int counter = 0, pos = 0;
					for (int i = 0; i < 3; i++)
					{
						while (str[counter] != '.')
						{
							counter++;
						}
						sent[i] = str.Substring(pos, counter - pos + 1);
						pos = counter + 1;
						counter++;
					}
					reader.Close();
					
					for (int i = 2; i != -1; i--)
					{
						Console.WriteLine(sent[i]);
					}
					
				}
				else
				{
					throw new Exception();
				}
			}
			catch
			{
				Console.WriteLine("Файл не существует");
			}
		}
	}
}